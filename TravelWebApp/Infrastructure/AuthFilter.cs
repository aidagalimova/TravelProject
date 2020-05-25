using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelWebApp.Data;

namespace TravelWebApp.Infrastructure
{
    public class AuthFilter : ActionFilterAttribute, IActionFilter
    {
        private readonly ApplicationContext _context;


        public override void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Cookies.ContainsKey("UserId"))
            {
                context.Result = new RedirectToRouteResult(
                new RouteValueDictionary(new { area = "Identity", page = "/Account/Login" }));
            }
            //if (_context.Users.FirstOrDefault(u=>u.Id == context.HttpContext.Request.Cookies["UserId"]).IsBanned)
            //{
            //    context.Result = new RedirectToRouteResult(
            //    new RouteValueDictionary(new { area = "Identity", page = "/Account/Login" }));
            //}
            base.OnActionExecuting(context);
        }
    }
}

