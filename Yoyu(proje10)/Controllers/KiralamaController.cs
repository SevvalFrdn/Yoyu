using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyu_proje10_.Models;

namespace Yoyu_proje10_.Controllers
{
    public class KiralamaController : Controller
    {
        // GET: Kiralama
        public ActionResult Index()
        {
            return View(DP.ReturnList<KiralamaModel>("KiralamaListele")); 
        }
        public ActionResult EY(int id = 0) //ekle yenile
        {
            if (id == 0)

                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@KiralamaNo", id);
                return View(DP.ReturnList<KiralamaModel>("KiralamaSirala", param).FirstOrDefault<KiralamaModel>());
            }

        }
        [HttpPost]
        public ActionResult EY(KiralamaModel kiralama)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@KiralamaNo", kiralama.KiralamaNo);
            param.Add("@MusteriNo", kiralama.MusteriNo);
            param.Add("@KiralamaBaslangicTarihi", kiralama.KiralamaBaslangicTarihi);
            param.Add("@KiralamaBitisTarihi", kiralama.KiralamaBitisTarihi);
            param.Add("@KiralamakIstediginSanatciVeEser", kiralama.KiralamakIstediginSanatciVeEser);
            DP.EXReturn("KiralamaEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("KiralamaNo", id);
            DP.EXReturn("KiralamaSil", param);
            return RedirectToAction("Index");
        }
    }
}