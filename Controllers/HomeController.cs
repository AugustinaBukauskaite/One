using Microsoft.AspNetCore.Mvc;
using One.Models;
using System.Diagnostics;

namespace One.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }

    }

}