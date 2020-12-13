using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int ID = 1)
        {

            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;

            return View();
        }


        /* GET: /HelloWorld/
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }*/


        // GET: /HelloWorld/Welcome/ 
        /*public string Welcome()
        {

            return "This is the Welcome action method...";
        }*/
        /*public string Welcome(string name, int level = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", Level is: " + level);
        }
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }*/
        
    }
}
