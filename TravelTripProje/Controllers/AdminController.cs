using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
using PagedList;
using PagedList.Mvc;
using System.Runtime.Remoting.Messaging;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        TravelTripProje.Models.Siniflar.Context c = new TravelTripProje.Models.Siniflar.Context();
        [Authorize]
        public ActionResult Index(int sayfa = 1)
        {
            var degerler = c.Blogs.ToList().ToPagedList(sayfa, 4); //PagedList, istenilen sayıda veriyi listeler.
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges(); //Context'den gelen c parametresine Textboxfor'dan gelen p parametresi değerleri eklenir ve kaydedilir.
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult HakkimizdaListesi()
        {
            var hakkimizda=c.Hakkimizdas.ToList();
            return View(hakkimizda);
        }
        public ActionResult HakkimizdaGetir(int id)
        {
            var hkmz = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", hkmz);
        }
        public ActionResult HakkimizdaSil(int id)
        {
            var ha = c.Hakkimizdas.Find(id);
            c.Hakkimizdas.Remove(ha);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListesi");
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hkm = c.Hakkimizdas.Find(h.ID);
            hkm.FotoUrl = h.FotoUrl;
            hkm.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListesi");
        }
    }
}