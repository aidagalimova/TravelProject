using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Infrastructure
{
    public class IsAdminFilter : ActionFilterAttribute,IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Cookies.ContainsKey("admin"))
            {
                context.Result = new RedirectToRouteResult(new NotFoundResult());
            }
            base.OnActionExecuting(context);
        }
    }
}
