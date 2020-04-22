using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public bool IsSubscriber { get; set; }

        public bool IsBanned { get; set; }
    }
}
