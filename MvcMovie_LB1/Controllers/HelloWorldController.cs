using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie_LB1.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    //    // GET: /HelloWorld/Welcome/ 
    //    // Requires using System.Text.Encodings.Web;
    /*public string Welcome(string name, string surname, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, {surname}, NumTimes is: {numTimes}");
    }*/
    //}*/

    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}