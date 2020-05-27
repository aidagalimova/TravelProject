using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TravelWebApp.Models;

namespace TravelWebApp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<User> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            var returnUrl = Url.Content("/Identity/Account/Login");
            await _signInManager.SignOutAsync();
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions()
            {
                IsEssential = true
            };
            try
            {
                Response.Cookies.Delete("UserId", cookieOptions);
                Response.Cookies.Delete("admin", cookieOptions);
                _logger.LogInformation("User logged out.");
            }
            catch
            {
                _logger.LogInformation("Something happened");
            }
            return LocalRedirect(returnUrl);
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = Url.Content("/Identity/Account/Login");
            await _signInManager.SignOutAsync();
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions()
            {
                IsEssential = true
            };
            try
            {
                Response.Cookies.Delete("UserId", cookieOptions);
                Response.Cookies.Delete("admin", cookieOptions);
                _logger.LogInformation("User logged out.");
            } catch
            {
                _logger.LogInformation("Something happened");
            }
            return LocalRedirect(returnUrl);
            
        }
    }
}