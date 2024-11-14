using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Koyler
    {
        [Key]
        public int ID { get; set; }
        public string KoyAdi { get; set; }
        public string Aciklama { get; set; }
        public string KoyImage { get; set; }
    }
}