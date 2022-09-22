using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

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



        //GET: /HelloWorld/Welcome0/
        public string Welcome0()
        {
            return "This is Welcome action method....";
        }

        //GET: /HelloWorld/Welcomed/
        //https: //localhost:0000/HelloWorld/Welcomed?name=Prabin&numtimes=4

        public string Welcomed(string name, int numTimes = 1)    // method with parameter 
        {
            string x = $"Hello {name} , NumTimes is: {numTimes} ";
            return HtmlEncoder.Default.Encode(x); //Uses HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript.
        }

        //GET: /HelloWorld/Welcome        
        /*
        URL: https: //localhost:0000/HelloWorld/Welcome/3?name=Prabin
        In the preceding URL:
        The third URL segment matched the route parameter id.
        The Welcome method contains a parameter id that matched the URL template in the MapControllerRoute method.
        The trailing ? starts the query string.
        */

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"name = {name} , ID: {ID}");
        }

        /*  app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        In the preceding example:
        The third URL segment matched the route parameter id.
        The Welcome method contains a parameter id that matched the URL template in the MapControllerRoute method.
        The trailing ? (in id?) indicates the id parameter is optional.
        */




        //<------------Default is commented below------------>
        //public IActionResult Index()  
        //{
        //    return View();
        //}
        //</------------------------------------------------->
    }
}
