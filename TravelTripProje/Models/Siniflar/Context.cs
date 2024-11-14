using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    
    public class Context:DbContext //ilgilitablolara ulaşabilmek için dbcontext'ten miras alınır.
    {
        public DbSet<Admin> Admins { get; set; } //Adminin veritabanındaki ismi admins olur.
        public DbSet<AdresBlog> AdresBlogs { get; set; } //AdresBlogun veritabanındaki ismi AdresBlogs olur.
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Koyler> Koylers { get; set; }
        public DbSet<Yemek> Yemeks { get; set; }
        public DbSet<Kamp> Kamps { get; set; }
    }
}