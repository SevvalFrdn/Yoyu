using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yoyu_proje10_.Models
{
    public class SanatEseriModel
    {
        public int SanatEseriNo { get; set; }
        public int SanatciNo { get; set; }
        public string SanatEseriAdi { get; set; }
        public string SanatEseriTuru { get; set; }
        public int SanatEseriYil { get; set; }
        public decimal SanatEseriFiyat { get; set; }
    }
}