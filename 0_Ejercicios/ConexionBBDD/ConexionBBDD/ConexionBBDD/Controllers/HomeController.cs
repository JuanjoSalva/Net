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
            List<string> categorias = new List<string>();
            //string connectionString = @"Data Source =.\SQLEXPRESS;Initial Catalog=Northwind; Integrated Security=SSPI";
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("Select * from Categories", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string categoryName = (string)reader["CategoryName"];
                            categorias.Add(categoryName);
                        }
                    }
                }
            }

            //USANDO VIEWBAG
            /*ViewBag.Categorias = categorias;
            return View();*/

            //PASANDOLO COMO SI FUERA UN MODELO
            return View(categorias);
        }      
    }
}
