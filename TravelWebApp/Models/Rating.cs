using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int Mark { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
