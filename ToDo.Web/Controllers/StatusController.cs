using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using ToDo.Models;
using ToDo.Web.Models;

namespace ToDo.Controllers
{
    public class StatusController : Controller
    {


        public IActionResult Index()
        {
            List<Status> durumlar = new List<Status>();

            SqlConnection conn = Db.Conn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Statuses", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                durumlar.Add(new Status { Id = (int)dr["Id"], Name = (string)dr["Name"], DateCreated = (DateTime)dr["DateCreated"] });
            }
            conn.Close();
            return View(durumlar);
        }
        public IActionResult Delete(int Id)
        {
            SqlConnection conn = Db.Conn();
            SqlCommand cmd = new SqlCommand("DELETE FROM Statuses WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("id", Id);
            conn.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            if (affectedRows > 0)
            {
                TempData["Success"] = "Durum Başarıyla Silinmiştir !";
            }
            else
            {
                TempData["error"] = "HATA ! Silme işlemi başarısız !";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Status status)
        {
            return RedirectToAction("Index");
        }
    }
}
