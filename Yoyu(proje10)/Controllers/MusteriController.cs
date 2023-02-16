using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyu_proje10_.Models;

namespace Yoyu_proje10_.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Index()
        {
            return View(DP.ReturnList<MusteriModel>("MusteriListele")); 
        }

        public ActionResult EY(int id = 0) //ekle yenile
        {
            if (id == 0)

                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MusteriNo", id);
                return View(DP.ReturnList<MusteriModel>("MusteriSirala", param).FirstOrDefault<MusteriModel>());
            }

        }
        [HttpPost]
        public ActionResult EY(MusteriModel musteri)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MusteriNo", musteri.MusteriNo);
            param.Add("@MusteriAdi", musteri.MusteriAdi);
            param.Add("@MusteriSoyadi", musteri.MusteriSoyadi);
            param.Add("@MusteriMail", musteri.MusteriMail);
            param.Add("@MusteriAdres", musteri.MusteriAdres);
            param.Add("@MusteriTelefon", musteri.MusteriTelefon);
            param.Add("@MusteriYas", musteri.MusteriYas);
            DP.EXReturn("MusteriEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("MusteriNo", id);
            DP.EXReturn("MusteriSil", param);
            return RedirectToAction("Index");
        }

    }
}