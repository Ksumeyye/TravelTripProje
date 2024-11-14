using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        TravelTripProje.Models.Siniflar.Context c=new TravelTripProje.Models.Siniflar.Context();
        public ActionResult Index()
        {
            var degerler=c.Kamps.ToList();
            return View(degerler);
        }
        public ActionResult KampDetay()
        {
            var deger = c.Kamps.ToList();
            return View(deger);
        }
        public ActionResult KoyDetay()
        {
            var koyd = c.Koylers.ToList();
            return View(koyd);
        }
        public ActionResult YemekDetay()
        {
            var yemekd = c.Yemeks.ToList();
            return View(yemekd);
        }
        public PartialViewResult KampPartial1()
        {
            var degerler = c.Kamps.OrderByDescending(x => x.ID).Take(8).ToList(); //OrderByDescending().Take(2) Z'den A'ya En Büyük 2 Değeri Getirir.
            return PartialView(degerler);
        }
        public PartialViewResult KoyPartial2()
        {
            var deger = c.Koylers.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult YemekPartial3()
        {
            var deger = c.Yemeks.OrderByDescending(x => x.ID).Take(1).ToList();
            return PartialView(deger);
        }
    }
}