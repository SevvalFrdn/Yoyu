using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyu_proje10_.Models;

namespace Yoyu_proje10_.Controllers
{
    public class SiparisController : Controller
    {
        // GET: Siparis
        public ActionResult Index()
        {
            return View(DP.ReturnList<SiparisModel>("SiparisListele")); 
        }

        public ActionResult EY(int id = 0) //ekle yenile
        {
            if (id == 0)

                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SiparisNo", id);
                return View(DP.ReturnList<SiparisModel>("SiparisSirala", param).FirstOrDefault<SiparisModel>());
            }

        }
        [HttpPost]
        public ActionResult EY(SiparisModel siparis)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SiparisNo", siparis.SiparisNo);
            param.Add("@MusteriNo", siparis.MusteriNo);
            param.Add("@SiparisAdi", siparis.SiparisAdi);
            param.Add("@SiparisTarih", siparis.SiparisTarih);
            DP.EXReturn("SiparisEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("SiparisNo", id);
            DP.EXReturn("SiparisSil", param);
            return RedirectToAction("Index");
        }
    }
}