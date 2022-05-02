using Microsoft.AspNetCore.Mvc;

namespace practica2.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            ViewData["WelcomeMessage"] = "Welcome";
            return View();
        }

        public IActionResult Validate(string correo, string clave)
        {
           
                return RedirectToAction("Index", "Customer", new { Area = "Sales" });
           

        }


    }

}