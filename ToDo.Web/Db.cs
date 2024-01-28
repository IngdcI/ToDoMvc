using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ToDo.Web
{
    public class Db
    {
        public static SqlConnection Conn()
        {
            return new SqlConnection("Server=LAPTOP-RFP2OHGU\\SQLEXPRESS;Database=ToDo;Integrated Security=True;TrustServerCertificate=Yes");
        }
    }
}
