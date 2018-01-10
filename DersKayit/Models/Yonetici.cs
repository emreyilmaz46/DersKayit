using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DersKayit.Models
{
    public class Yonetici
    {
        public int YoneticiId { get; set; }
        public string YoneticiAd { get; set; }
        public string YoneticiSoyad { get; set; }
        public int YoneticiNo { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
        [Display(Name = "Hoca Adı")]
        public string YoneticiTamAd => $"{this.YoneticiAd} {this.YoneticiSoyad}";

        public Yonetici()
        {
            this.Rol = "Yonetici";
        }
    }
}