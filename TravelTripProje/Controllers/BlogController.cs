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
        BlogYorum by = new BlogYorum();// BlogYorum'dan by adında bir nesne türetiyorum.
        // GET: Blog
        public ActionResult Index()
        {
            by.Deger1=b.Blogs.ToList();
            by.Deger3 = b.Blogs.Take(3).ToList();
            //var bloglar = b.Blogs.ToList();
            return View(by);
        }
       
        public ActionResult BlogDetay(int? id)
        {
            //var blogbul = b.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1=b.Blogs.Where(x=>x.ID==id).ToList();
            by.Deger2 =b.Yorumlars.Where(x => x.ID == id).ToList();
            return View(by);
        }

    }
}