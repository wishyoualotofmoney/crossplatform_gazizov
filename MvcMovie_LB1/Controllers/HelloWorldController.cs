using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie_LB1.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, string surname, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, {surname}, NumTimes is: {numTimes}");
    }
}