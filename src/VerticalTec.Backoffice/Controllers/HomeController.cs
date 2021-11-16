using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace VerticalTec_Backoffice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Redirect("Demo");
        }

        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture))
            );
            return LocalRedirect(returnUrl);
        }

        public IActionResult SetTheme(string themeName)
        {
            Response.Cookies.Append("ThemeName", themeName);
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
