using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yoyu_proje10_.Models
{
    public class KiralamaModel
    {
        public int KiralamaNo { get; set; }
        public int MusteriNo { get; set; }
        public DateTime KiralamaBaslangicTarihi { get; set; }
        public DateTime KiralamaBitisTarihi { get; set; }
        public string KiralamakIstediginSanatciVeEser { get; set; }

    }
}