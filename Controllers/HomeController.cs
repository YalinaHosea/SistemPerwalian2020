using Microsoft.AspNetCore.Mvc;

namespace SistemPerwalian2020.Controllers{
    public class HomeController : Controller{

       public IActionResult Index(){
            return View();
        }

        public string About(){
            return "Hello from About";
        }
    }
}