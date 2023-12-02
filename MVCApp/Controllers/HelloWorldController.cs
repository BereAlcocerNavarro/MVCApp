using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        //GET: /HelloWorld
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        //GET: /HelloWorld/Welcome
        //public string Welcome(string name, int numTimes=1)
        //{
        //    //return "This is the welcome action method...";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " +name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
