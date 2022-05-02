using Microsoft.AspNetCore.Mvc;

namespace practica2.Areas.Sales.Controllers
{
    [Area("Sales")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var listado = new List<Customer>();

            

            var Customer = new Customer();
            Customer.Id = 1;
            Customer.FullName = "Edith Lopez Aguero";
            Customer.Email = "edith@gmail.com";
            Customer.Country = "PERÚ";
            Customer.Phone = 999665829;

            var Customer2 = new Customer();
            Customer2.Id = 2;
            Customer2.FullName = "Agusto Torres Torres";
            Customer2.Email = "agus@gmail.com";
            Customer2.Country = "Bogota";
            Customer2.Phone = 735455829;

            var Customer3 = new Customer();
            Customer3.Id = 3;
            Customer3.FullName = "Loda Driano  black Shelby";
            Customer3.Email = "pokemonblack2@gmail.com";
            Customer3.Country = "Uruguay";
            Customer3.Phone = 641354699;

            var Customer4 = new Customer();
            Customer4.Id = 4;
            Customer4.FullName = "Grethel Escalante  Gomez";
            Customer4.Email = "Grethel@gmail.com";
            Customer4.Country = "Argentina";
            Customer4.Phone = 883546987;

            var Customer5 = new Customer();
            Customer5.Id = 5;
            Customer5.FullName = "Agusto Torres Torres";
            Customer5.Email = "agus@gmail.com";
            Customer5.Country = "Bogota";
            Customer5.Phone = 752984623;

         

            ViewData["var1"] = Customer;
            ViewData["var2"] = Customer2;
            ViewData["var3"] = Customer3;
            ViewData["var4"] = Customer4;
            ViewData["var5"] = Customer5;



            foreach (var item in listado)
            {
                Console.WriteLine(item.Id + " - " + item.FullName + " - " + item.Email + " - " + item.Country + " - " + item.Phone);
            }

            return View();
        }
    }
}
