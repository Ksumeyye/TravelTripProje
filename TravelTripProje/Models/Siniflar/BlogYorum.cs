﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get;set; } //IEnumerable ile bir view içerisinde birden fazla tablodan değer çekiyorum.
        public IEnumerable<Blog>Deger3 { get; set; }

    }
}