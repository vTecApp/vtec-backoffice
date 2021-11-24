using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VerticalTec.Backoffice.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("FormInput");
        }

        public IActionResult FormInput()
        {
            return View();
        }

        public IActionResult PivotGrid()
        {
            return View();
        }

        public IActionResult DataGrid()
        {
            return View();
        }

        public IActionResult Chart()
        {
            return View();
        }

        public async Task<IActionResult> CallApi()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.GetStringAsync("https://localhost:5001/api/identity");

            ViewBag.Json = JArray.Parse(content).ToString();
            return View("jwt");
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
