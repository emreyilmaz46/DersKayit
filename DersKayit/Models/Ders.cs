using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DersKayit.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public int DersKodu { get; set; }
        public int Kontenjan { get; set; }
        public bool OnSartVarMi { get; set; }

        public virtual int BolumId { get; set;}
        public virtual int HocaId { get; set; }
        public virtual List<Ders> OnsartDersler { get; set; }
        public virtual List<Ogrenci> KayitliOgrenciler { get; set; }
    }
}