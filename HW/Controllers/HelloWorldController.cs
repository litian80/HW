using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "this is my <b>default</b> action...";
        }


        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}