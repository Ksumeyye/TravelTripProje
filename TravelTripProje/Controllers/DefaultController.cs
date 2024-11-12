using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TravelTripProje.Models.Siniflar.Context c = new TravelTripProje.Models.Siniflar.Context();
        public ActionResult Index()
        {
           var degerler=c.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler=c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList(); //OrderByDescending().Take(2) En Son Eklenen 2 Değeri Getirir.
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        { 
            var deger = c.Blogs.OrderByDescending(x=>x.ID).Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList(); //Take() İstenilen sayıda değeri almaya yarar.
            return PartialView(deger);
        }
    }
}