using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Öğrenci Adı")]
        public string OgrenciTamAd => $"{this.OgrenciAd} {this.OgrenciSoyad}";

        public virtual Bolum Bolum { get; set; }
        public virtual List<Ders> Dersler { get; set; }

        public Ogrenci()
        {
            this.Rol = "Ogrenci";
            this.Dersler = new List<Ders>();
        }
    }
}