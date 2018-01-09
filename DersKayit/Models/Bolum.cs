using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DersKayit.Models
{
    public class Bolum
    {
        public int BolumId { get; set; }
        [Display(Name = "Bölüm Adı")]
        public string BolumAdi { get; set; }
    }
}