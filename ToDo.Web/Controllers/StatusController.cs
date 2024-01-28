using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using ToDo.Web.Models;

namespace ToDo.Web.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            List<Status> durumlar = new List<Status>();

            SqlConnection conn = Db.Conn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Status", conn);
            conn.Open();
            SqlDataReader dr =cmd.ExecuteReader();
            while (dr.Read())
            {
                durumlar.Add(new Status{ Id = (int)dr["Id"], Name = (string)dr["Name"], DateCreated = (DateTime)dr["DateCreated"] });
            }
            conn.Close();
            return View(durumlar);
        }
    }
}
