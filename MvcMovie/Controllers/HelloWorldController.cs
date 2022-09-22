using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /Hello World/      ----its also the class name of this controller

        public string Index()
        {
            string name = "Prabin Bhagat";
            return "This is my Default action....i.e. Index " + "Hello " + name;
        }

        //GET: /HelloWorld/Welcome/

        public string Welcome()
        {
            return "This is Welcome action method....";
        }


        //<------------Default is commented below------------>
        //public IActionResult Index()  
        //{
        //    return View();
        //}
        //</------------------------------------------------->
    }   
}
