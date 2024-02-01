using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using ToDo.Models;
using ToDo.Web.Models;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
