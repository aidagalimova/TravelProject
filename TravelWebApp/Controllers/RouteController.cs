using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelWebApp.Data;
using TravelWebApp.Services;

namespace TravelWebApp.Controllers
{
    public class RouteController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly YandexApiService _yandexApiService;

        public RouteController(ApplicationContext context, YandexApiService yandexApiService )
        {
            _yandexApiService = yandexApiService;
            _context = context;
        }


        public async Task<IActionResult> SearchRoute()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchRoute(string cityFrom, string cityTo)
        {
            var cityF = _context.Cities.FirstOrDefault(c => c.Name == cityFrom);
            var cityT = _context.Cities.FirstOrDefault(c => c.Name == cityTo);

            var res = _yandexApiService.GetScheduleBetweenStations(cityF.YandexCode, cityT.YandexCode);
            Console.WriteLine(res);
            return View();
        }
    }
}
