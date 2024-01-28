using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.Web.Models;

namespace ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
