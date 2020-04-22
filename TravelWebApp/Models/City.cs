using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }


        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
