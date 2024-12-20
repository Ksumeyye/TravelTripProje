﻿using System;
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
            by.Deger2 = b.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            //var bloglar = b.Blogs.ToList();
            /*by.Deger3 = b.Blogs.Take(3).ToList();*/ //Baştan sona doğru by.deger3teki değerleri getirir.
            /*by.Deger3.Reverse();*/// Gelen değerlerde ters sıralama yapar
            by.Deger3 = b.Blogs.Take(3).AsEnumerable().Reverse().ToList(); //AsEnumerable(), veri kaynağından almak istediğim bilgileri tam olarak belirtebilmem için kullandım.AsEnumerable() metodunu kullanarak LINQ to Entities sorgusunu bellek içi LINQ sorgusuna dönüştürdüm. Bu şekilde, daha sonra koleksiyon üzerinde ters sıralama işlemi gerçekleşir.
            return View(by);
        }
       
        public ActionResult BlogDetay(int? id)
        {
            //var blogbul = b.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = b.Blogs.Where(x => x.ID == id).ToList();
            //by.Deger1 = b.Blogs.Take(3).ToList();
            by.Deger2 =b.Yorumlars.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            b.Yorumlars.Add(y);
            b.SaveChanges();
            return PartialView("Index");
        }
    }
}