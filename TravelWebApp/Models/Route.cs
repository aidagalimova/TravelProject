using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int Duration { get; set; }


        public int CityFromId { get; set; }

        public int CityToId { get; set; }

    }
}
