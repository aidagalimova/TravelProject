using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelWebApp.AOP;
using TravelWebApp.Data;
using TravelWebApp.Infrastructure;
using TravelWebApp.Models;

namespace TravelWebApp.Controllers
{
    [TraceAspect]
    [AuthFilter]
    public class ProfileController : Controller
    {
        private readonly ApplicationContext _context;
        public ProfileController(ApplicationContext context)
        {
            _context = context;
        }


        // GET: Profile/Details/5
        public async Task<IActionResult> Details(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            var cities_rate =await _context.Ratings.Include(r=>r.City).Include(r=>r.City.Country).Where(r=>r.UserId==id).ToListAsync();
            var user_rate = new User_Rate { User = user , Ratings = cities_rate};
            return View(user_rate);
        }
    }

    public class User_Rate
    {
        public User User { get; set; }
        public List<Rating> Ratings {get;set;}
    }
}