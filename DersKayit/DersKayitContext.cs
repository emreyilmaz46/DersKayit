using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DersKayit.Models;

namespace DersKayit
{
    public class DersKayitContext: DbContext
    {
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Hoca> Hocalar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
    }
}