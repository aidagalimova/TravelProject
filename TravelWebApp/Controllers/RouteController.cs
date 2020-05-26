using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelWebApp.AOP;
using TravelWebApp.Data;
using TravelWebApp.Infrastructure;
using TravelWebApp.Services;

namespace TravelWebApp.Controllers
{
    [TraceAspect]
    [AuthFilter]
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

        public RouteModel ParseYandex(dynamic yandexJson, int minDist)
        {
            var res = new RouteModel();
            foreach (var segment in yandexJson["segments"])
            {
                if(minDist == int.Parse(segment["duration"].ToString().Split(".")[0]))
                {
                    res.Arrival = segment["to"]["station_type_name"].ToString() + " " + segment["to"]["title"].ToString();
                    res.Company = segment["thread"]["carrier"]["title"].ToString();
                    res.Departure = segment["from"]["station_type_name"].ToString() + " " + segment["from"]["title"].ToString();
                    res.URL = segment["thread"]["carrier"]["url"].ToString();
                    break;
                }
            }
            return res;
        }


        public List<RouteModel> GetRoute(int cityFromId, int cityToId)
        {
            var resultList = new List<RouteModel>();
            var search = new List<List<int>>();
            var currentCities = new List<int>();
            currentCities.Add(cityFromId);
            var tt = new List<int>();
            tt.Add(cityFromId);
            search.Add(tt);

            var end = false;
            while(!end)
            {
                var len = currentCities.Count;
                var en = search.Count;
                for (var i=0; i<search[i].Count;++i)
                {
                    Console.WriteLine(search);
                    var last = search[i][search[i].Count-1];
                    var routesLocal = _context.Routes.Where(c => c.CityFromId == last).AsEnumerable();
                    len = currentCities.Count;
                    foreach (var route in routesLocal)
                    {
                        Console.WriteLine(currentCities);
                        if(currentCities.Contains(route.CityToId))
                        {
                            continue;
                        }
                        else if (cityToId != route.CityToId)
                        {
                            var newL = search[i].GetRange(0,search[i].Count);
                            currentCities.Add(route.CityToId);
                            newL.Add(route.CityToId);
                            search.Add(newL);
                            en = search.Count;
                        } else
                        {
                            Console.WriteLine("1123");
                            var lastId = -1;
                            foreach(var cityIds in search[i])
                            {
                                if (lastId == -1)
                                {
                                    lastId = cityIds;
                                    continue;
                                }
                                var c1 = _context.Cities.FirstOrDefault(c => c.Id == lastId);
                                var c2 = _context.Cities.FirstOrDefault(c => c.Id == cityIds);
                                RouteModel rm = ParseYandex(_yandexApiService.GetScheduleBetweenStations(c1.YandexCode, c2.YandexCode),
                                    _context.Routes.FirstOrDefault(c=>c.CityFromId==c1.Id && c.CityToId == c2.Id).Duration);
                                rm.ShortTitle = c1.Name + " - " + c2.Name;
                                resultList.Add(rm);
                                lastId = cityIds;
                            }
                            var c11 = _context.Cities.FirstOrDefault(c => c.Id == lastId);
                            var c22 = _context.Cities.FirstOrDefault(c => c.Id == cityToId);
                            RouteModel rmm = ParseYandex(_yandexApiService.GetScheduleBetweenStations(c11.YandexCode, c22.YandexCode),
                                _context.Routes.FirstOrDefault(c => c.CityFromId == c11.Id && c.CityToId == c22.Id).Duration);
                            rmm.ShortTitle = c11.Name + " - " + c22.Name;
                            resultList.Add(rmm);
                            return resultList;
                        }
                    }
                }

                if(len == currentCities.Count)
                {
                    return resultList;
                }
            }

            return resultList;
        }


        [HttpPost]
        public async Task<IActionResult> RouteResult(string cityFrom, string cityTo)
        {
            var cityF = _context.Cities.FirstOrDefault(c => c.Name == cityFrom);
            var cityT = _context.Cities.FirstOrDefault(c => c.Name == cityTo);
            var res = GetRoute(cityF.Id, cityT.Id);
            return View(res);
        }
    }

    public class RouteModel
    {
        public string ShortTitle;
        public string Departure;
        public string Arrival;
        public string Company;
        public string URL;
    }
}
