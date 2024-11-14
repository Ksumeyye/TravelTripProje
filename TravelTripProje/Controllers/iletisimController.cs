using TravelTripProje.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers
{
    public class iletisimController : Controller
    {
        TravelTripProje.Models.Siniflar.Context c=new TravelTripProje.Models.Siniflar.Context();
        // GET: iletisim
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult mesajGonder()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult mesajGonder(iletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return PartialView();
        }
    }
}