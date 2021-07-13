using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionBBDD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> paises = new List<string>();
            //string connectionString = "Server = tcp:consotospain.database.windows.net,1433; Initial Catalog = consotospain; Persist Security Info = False; User ID = manager; Password = P3ccs05d123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            string connectionString =   "Server = tcp:juanjo.database.windows.net,1433; Initial Catalog = Pruebas; Persist Security Info = False; User ID = juanjo; Password =Prueba12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("Select * from Ciudades", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string categoryName = (string)reader["Nombre"];
                            paises.Add(categoryName);
                        }
                    }
                }
            }

            //USANDO VIEWBAG
            /*ViewBag.Categorias = categorias;
            return View();*/

            //PASANDOLO COMO SI FUERA UN MODELO
            return View(paises);
        }      
    }
}
