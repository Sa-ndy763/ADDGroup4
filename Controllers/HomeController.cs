using System;
using Microsoft.AspNetCore.Mvc;

namespace ADDGroup4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult sum()
        {
            return View();
        }

        [HttpPost]
        public IActionResult add()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["txtFirst"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["txtSecond"].ToString());
            int result = num1 + num2;
            ViewBag.SumResult = result.ToString();
            return View("sum");
        }
    }
}