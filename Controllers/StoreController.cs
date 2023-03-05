using Microsoft.AspNetCore.Mvc;
using System.Web;
using One.Models;

namespace One.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "1";
        }
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}
