using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Chat
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
