using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
