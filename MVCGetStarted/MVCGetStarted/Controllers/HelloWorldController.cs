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
        // GET: /HelloWorld
        public String Index()
        {
            return "Default Action this is";
        }

        // GET: /HelloWorld/Welcome
        public String Welcome()
        {
            return "Welcome action method!";
        }
    }
}
