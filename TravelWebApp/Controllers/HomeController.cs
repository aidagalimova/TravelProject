using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TravelWebApp.AOP;
using TravelWebApp.Data;
using TravelWebApp.Models;
using TravelWebApp.MongoModels;
using TravelWebApp.Services;
using Country = TravelWebApp.MongoModels.Country;

namespace TravelWebApp.Controllers
{
    [TraceAspect]
    public class HomeController : Controller
    {

        private ApplicationContext _applicationContext;

        private TravelService _travelService;

        public HomeController(ApplicationContext context, TravelService travelService)
        {
            _applicationContext = context;
            _travelService = travelService;
        }



        public IActionResult Index()

        {
            //foreach(var cmongo in _travelService.GetCountries())
            //{
            //    var c = new Models.Country();
            //    c.Name = cmongo.Title;
            //    c.Code = cmongo.Codes[0].Yandex_code;
            //    _applicationContext.Add(c);
            //}
            //_applicationContext.SaveChanges();
            //var answer = "";
            //var request = System.Net.WebRequest.Create("https://api.rasp.yandex.net/v3.0/stations_list/?apikey=1a54691b-37d6-4213-ad2c-90d1c5a2a7e7&lang=ru_RU&format=json");
            //using (System.Net.WebResponse response = request.GetResponse())
            //{
            //    using (System.IO.StreamReader rd = new System.IO.StreamReader(response.GetResponseStream()))
            //    {
            //        answer = rd.ReadToEnd();

            //    }
            //}
            //var values = JsonConvert.DeserializeObject<dynamic>(answer);
            //foreach(var country in values["countries"])
            //{
            //    var cntry = new MongoModels.Country();
            //    cntry.Regions = new List<string>();
            //    cntry.Codes = new List<Code>();
            //    cntry.Title = country["title"];
            //    var codeCountry = new Code();
            //    codeCountry.Yandex_code = country["codes"]["yandex_code"];
            //    cntry.Codes.Add(_travelService.CreateCode(codeCountry));
            //    foreach(var region in country["regions"])
            //    {
            //        var rg = new Region();
            //        rg.Settlements = new List<Settlement>();
            //        rg.Codes = new List<Code>();
            //        rg.Title = region["title"];
            //        var codeRegion = new Code();
            //        codeRegion.Yandex_code = region["codes"]["yandex_code"];
            //        rg.Codes.Add(_travelService.CreateCode(codeRegion));
            //        foreach(var settlement in region["settlements"])
            //        {
            //            var st = new Settlement();
            //            st.Stations = new List<Station>();
            //            st.Codes = new List<Code>();
            //            st.Title = settlement["title"];
            //            var codeSt = new Code();
            //            codeSt.Yandex_code = settlement["codes"]["yandex_code"];
            //            st.Codes.Add(_travelService.CreateCode(codeSt));
            //            foreach(var station in settlement["stations"])
            //            {
            //                var stat = new Station();
            //                stat.Direction = station["direction"];
            //                stat.Codes = new List<Code>();
            //                var codeStat = new Code();
            //                codeStat.Yandex_code = station["codes"]["yandex_code"];
            //                stat.Codes.Add(_travelService.CreateCode(codeStat));
            //                stat.Station_type = station["station_type"];
            //                stat.Title = station["title"];
            //                stat.Longitude = station["longitude"];
            //                stat.Transport_type = station["transport_type"];
            //                stat.Latitude = station["latitude"];
            //                st.Stations.Add(_travelService.CreateStation(stat));
            //            }
            //            rg.Settlements.Add(_travelService.CreateSettlement(st));
            //        }    
            //        cntry.Regions.Add(_travelService.CreateRegion(rg).Id);
            //    }

            //    _travelService.CreateCountry(cntry);
            //}
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
