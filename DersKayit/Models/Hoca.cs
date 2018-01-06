using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public virtual int BolumId { get; set; }
        public virtual List<Ders> Dersler { get; set; }

        public Hoca()
        {
            this.Rol = "Hoca";
        }
    }
}