using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using TravelWebApp.AOP;
using TravelWebApp.Data;
using TravelWebApp.Infrastructure;
using TravelWebApp.Models;
using TravelWebApp.Services;

namespace TravelWebApp.Controllers
{
    [TraceAspect]
    [AuthFilter]
    [IsAdminFilter]
    public class AdminController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly string adminMail;
        private readonly string adminPassword;
        private readonly TravelService _travelService;
        private readonly YandexApiService _yandexApiService;

        public AdminController(ApplicationContext context, TravelService travelService,YandexApiService yandexApiService)
        {
            _yandexApiService = yandexApiService;
            adminMail = "travelwebproject1@gmail.com";
            adminPassword = "15171517Travel1";
            _context = context;
            _travelService = travelService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> AddCity()
        {
            return View();
        }

        public async Task<IActionResult> Cities()
        {
            var cities = _context.Cities.Include(c=>c.Country).AsEnumerable();
            return View(cities);
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.Where(x=> x.Email != "admin@mail.ru").ToListAsync();
            var m = new UserListModel();
            m.users = users;

            return View(m);
        }

        [HttpPost]
        public JsonResult GetCountries()
        {
            var countries = _travelService.GetCountries().OrderBy(r=>r.Title);
            return Json(countries);

        }

        [HttpPost]
        public JsonResult GetRegions(string countryId)
        {
            var country = _travelService.GetCountries().FirstOrDefault(r=>r.Id == countryId);

            var regions = _travelService.GetRegions().Where(r => country.Regions.Contains(r.Id)).OrderBy(r => r.Title);
            return Json(regions);
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(AddCityModel data)
        {
            string path = "wwwroot/Cities/Details/img/" + data.Upload.FileName;
            var c = new City();
            if(_context.Countries.Any(country=>country.Name == _travelService.GetCountry(data.CountryId).Title))
            {
                c.CountryId = _context.Countries.FirstOrDefault(country => country.Name == _travelService.GetCountry(data.CountryId).Title).Id;
            } else
            {
                var country = new Country();
                country.Name = _travelService.GetCountry(data.CountryId).Title;
                _context.Add(country);
                await _context.SaveChangesAsync();
                c.CountryId = _context.Countries.FirstOrDefault(countr => countr.Name == _travelService.GetCountry(data.CountryId).Title).Id;
            }
            c.Description = data.Description;
            c.Image = data.Upload.FileName;
            c.Latitude = double.Parse(data.Latitude);
            c.Longitude = double.Parse(data.Longitude);
            c.Name = _travelService.GetSettlement(data.CityId).Title;
            c.YandexCode = _travelService.GetSettlement(data.CityId).Codes[0].Yandex_code;
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await data.Upload.CopyToAsync(fileStream);
            }
            _context.Add(c);
            await _context.SaveChangesAsync();
            Console.WriteLine(c.Id);
            Console.WriteLine("!@#!@#");
            foreach(var cc in _context.Cities.AsEnumerable())
            {
                if(cc.Id != c.Id)
                {
                    var k = _yandexApiService.GetScheduleBetweenStations(c.YandexCode, cc.YandexCode);
                    var minDist = 0;
                    foreach (var segment in k["segments"])
                    {
                        if (minDist==0 || segment["duration"] < minDist)
                        {
                            minDist = int.Parse(segment["duration"].ToString().Split(".")[0]);
                        }
                    }
                    if (minDist != 0)
                    {
                        var r = new Route();
                        r.CityFromId = c.Id;
                        r.CityToId = cc.Id;
                        r.Duration = minDist;
                        _context.Add(r);
                    }

                    k = _yandexApiService.GetScheduleBetweenStations(cc.YandexCode, c.YandexCode);
                    minDist = 0;
                    foreach (var segment in k["segments"])
                    {
                        if (minDist == 0 || segment["duration"] < minDist)
                        {
                            minDist = int.Parse(segment["duration"].ToString().Split(".")[0]);
                        }
                    }
                    if (minDist != 0)
                    {
                        var r = new Route();
                        r.CityFromId = cc.Id;
                        r.CityToId = c.Id;
                        r.Duration = minDist;
                        _context.Add(r);
                    }
                }
            }
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult GetCities(string regionId)
        {
            var settlements = _travelService.GetRegions().FirstOrDefault(r => r.Id == regionId).Settlements.OrderBy(r => r.Title);
            return Json(settlements);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeBannedStatus(string userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            user.IsBanned = !user.IsBanned;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(string mail)
        {
            var users = await _context.Users.Where(u => u.IsSubscriber == true).ToListAsync();
            foreach (var user in users)
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(user.Email);
                mailMessage.From = new MailAddress(adminMail);
                mailMessage.Body = mail;
                mailMessage.IsBodyHtml = false;
                mailMessage.Subject = "Рассылка с сайта путешественника";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(adminMail, adminPassword);
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
            }
            return LocalRedirect("~/Admin/Index");
        }
    }
    public class UserListModel
    {
        public List<User> users;
    }
    public class AddCityModel
    {
        public IFormFile Upload { get; set; } 
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Description { get; set; }
    }
}
