using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik {  get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }//İnterface kümeleme. Bir blogun birden fazla yorumu olabilir.C# Interface, yapısı gereği diğer sınıflara yol gösterici,
                                                            //rehberlik yapmak için oluşturulan, kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin
                                                            //aktarılmasını sağlayan bir kavramdır.
    }
}