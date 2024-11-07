using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context b=new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var bloglar = b.Blogs.ToList();
            return View(bloglar);
        }
        public ActionResult BlogDetay(int? id)
        {
            var blogbul = b.Blogs.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}