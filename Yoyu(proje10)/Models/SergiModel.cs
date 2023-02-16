using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yoyu_proje10_.Models
{
    public class SergiModel
    {
        public int SergiNo { get; set; }
        public string SergiAdi { get; set; }
        public DateTime SergiAcilisTarihi { get; set; }
        public DateTime SergiKapanisTarihi { get; set; }
        public string SergiAdres { get; set; }
        public string SergiTelefon { get; set; }
        public decimal SergiBiletFiyat { get; set; }

    }
}