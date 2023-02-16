using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yoyu_proje10_.Models
{
    public class SanatciModel
    {
        public int SanatciNo { get; set; }
        public string SanatciAdi { get; set; }
        public string SanatciSoyadi { get; set; }
        public DateTime SanatciDogumTarihi { get; set; }
        public string SanatciAdres { get; set; }
        public string SanatciTelefon { get; set; }
        public int SanatciDeneyimYil { get; set; }
        public int SergiNo { get; set; }

    }
}