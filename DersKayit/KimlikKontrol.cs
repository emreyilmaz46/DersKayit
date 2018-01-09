using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DersKayit
{
    public class KimlikKontrol: ValidationAttribute
    {
        public string kimlik { get; set; }

        public override bool IsValid(object value)
        {
            kimlik = value as string;
            if (kimlik != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}