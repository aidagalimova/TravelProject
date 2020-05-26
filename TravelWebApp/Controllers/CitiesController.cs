using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelWebApp.AOP;
using TravelWebApp.Data;
using TravelWebApp.Infrastructure;
using TravelWebApp.Models;

namespace TravelWebApp.Controllers
{
    [TraceAspect]
    [AuthFilter]
    public class CitiesController : Controller
    {
        private readonly ApplicationContext _context;

        public CitiesController(ApplicationContext context)
        {
            _context = context;
        }


        // POST: Citites/AddRating
        [HttpPost]
        public async Task<IActionResult> AddRating(int mark,int cityId)
        {
            var userId = Request.Cookies["UserId"];
            if (_context.Ratings.Any(r => r.CityId==cityId && r.UserId == userId)){
                var rating = await _context.Ratings.FirstOrDefaultAsync(r => r.CityId == cityId && r.UserId == userId);
                rating.Mark = mark;
                _context.Update(rating);

            } else
            {
                Console.WriteLine(cityId);
                Console.WriteLine(mark);
                Console.WriteLine(userId);

                var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id == cityId);
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                var rating = new Rating { CityId = city.Id, UserId = user.Id, Mark = mark };
                _context.Add(rating);
            }
            await _context.SaveChangesAsync();
            return NoContent();

        }


        [HttpPost]
        public JsonResult SearchCity(string text)
        {
            var cities = _context.Cities.Include(c=>c.Country).Where(s => s.Name.Contains(text)).ToList();

            return Json(cities);
        }


        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .Include(c => c.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            var userId = Request.Cookies["UserId"];
            var rating = await _context.Ratings.FirstOrDefaultAsync(r => r.CityId == id && r.UserId == userId);
            if (city == null)
            {
                return NotFound();
            }
            var cr = new CityRating { City = city, Rating = rating };
            return View(cr);
        }

        public async Task<IActionResult> CityRating()
        {
            var result =new List<CityModelRating>();
            foreach(var t in _context.Cities.AsEnumerable())
            {
                var cm = new CityModelRating();
                cm.CityId = t.Id;
                cm.City = t.Name;
                if (_context.Ratings.Any(c => c.CityId == t.Id))
                {
                    cm.AverageCount = _context.Ratings.Where(c => c.CityId == t.Id).Average(c => c.Mark);
                }
                cm.IsVisited = _context.Ratings.Any(c => c.CityId == t.Id && c.UserId == Request.Cookies["UserId"]);
                if (cm.IsVisited)
                {
                    cm.UserMark = _context.Ratings.FirstOrDefault(c => c.CityId == t.Id && c.UserId == Request.Cookies["UserId"]).Mark;
                }
                result.Add(cm);
            }
            return View(result);
        }


        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.Id == id);
        }
    }
    public class AjaxRatingModel
    {
        public int mark { get; set; }
        public int cityId { get; set; }
    }

    public class CityModelRating
    {
        public int CityId;
        public string City;
        public double AverageCount;
        public bool IsVisited;
        public int UserMark;

    }
}
