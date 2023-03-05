using Microsoft.AspNetCore.Mvc;
using System.Web;
using One.Models;

namespace One.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);
        }
        public ActionResult Browse(string Genre)
        {
            var genreModel = new Genre { Name = Genre };
            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}
