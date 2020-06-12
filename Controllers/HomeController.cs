using Microsoft.AspNetCore.Mvc;

namespace SistemPerwalian2020.Controllers{
    public class HomeController : Controller{

        public string Index(){
            return "Hello from Controller";
        }

        public string About(){
            return "Hello from About";
        }
    }
}