using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace DersKayit.Models
{
    public class Hoca
    {
        public int HocaId { get; set; }
        public string HocaAd { get; set; }
        public string HocaSoyad { get; set; }
        public string HocaNo { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
        [Display(Name = "Hoca Adı")]
        public string HocaTamAd => $"{this.HocaAd} {this.HocaSoyad}";

        public virtual Bolum Bolum { get; set; }
        public virtual List<Ders> Dersler { get; set; }

        public Hoca()
        {
            this.Rol = "Hoca";
            this.Dersler = new List<Ders>();
        }
    }
}