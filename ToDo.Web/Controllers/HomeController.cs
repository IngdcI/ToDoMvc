using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.Web.Models;

namespace ToDo.Controllers
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
