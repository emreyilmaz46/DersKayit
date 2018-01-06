using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DersKayit.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public int OgrenciNo { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }

        public virtual int BolumId { get; set; }
        public virtual List<Ders> Dersler { get; set; }

        public Ogrenci()
        {
            this.Rol = "Ogrenci";
        }
    }
}