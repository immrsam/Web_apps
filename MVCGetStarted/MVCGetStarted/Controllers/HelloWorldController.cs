using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCGetStarted.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 5)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // GET: /HelloWorld
        /*public String Index()
        {
            return "Default Action this is";
        }*/

        // GET: /HelloWorld/Welcome
        /*
        public String Welcome()
        {
            return "Welcome action method!";
        }*/

        // GET: /HelloWorld/Welcome?name=Sam
        /*
        public String Welcome(string name)
        {
            return HtmlEncoder.Default.Encode($"Welcome {name}");
        }*/

        // GET: /HelloWorld/Welcome?name=Sam&ID=3882 or /HelloWorld/Welcome/3882?name=Sam
        // ID matches route parameter
        // The Welcome method contains a parameter id that matched the URL template in the MapControllerRoute method.
        // The trailing ? starts the query string

        /*public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }*/
    }
}
