using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DersKayit.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        [Display(Name = "Ders Adı")]
        public string DersAdi { get; set; }
        [Display(Name = "Ders Kodu")]
        public int DersKodu { get; set; }
        [Display(Name = "Kontenjan")]
        public int Kontenjan { get; set; }
        [Display(Name = "Ön Şart")]
        public bool OnSartVarMi { get; set; }

        public virtual int BolumId { get; set;}
        public virtual int HocaId { get; set; }
        public virtual List<Ders> OnsartDersler { get; set; }
        public virtual List<Ogrenci> KayitliOgrenciler { get; set; }

        public Ders()
        {
            this.KayitliOgrenciler = new List<Ogrenci>();
            this.OnsartDersler = new List<Ders>();
        }
    }
}