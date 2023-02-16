using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyu_proje10_.Models;

namespace Yoyu_proje10_.Controllers
{
    public class SergiController : Controller
    {
        // GET: Sergi
        public ActionResult Index()
        {
            return View(DP.ReturnList<SergiModel>("SergiListele")); 
        }

    
        public ActionResult EY(int id = 0) //ekle yenile
        {
            if (id == 0)

                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SergiNo", id);
                return View(DP.ReturnList<SergiModel>("SergiSirala", param).FirstOrDefault<SergiModel>());
            }

        }
        [HttpPost]
        public ActionResult EY(SergiModel sergi)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SergiNo", sergi.SergiNo);
            param.Add("@SergiAdi", sergi.SergiAdi);
            param.Add("@SergiAcilisTarihi", sergi.SergiAcilisTarihi);
            param.Add("@SergiKapanisTarihi", sergi.SergiKapanisTarihi);
            param.Add("@SergiAdres", sergi.SergiAdres);
            param.Add("@SergiTelefon", sergi.SergiTelefon);
            param.Add("@SergiBiletFiyat", sergi.SergiBiletFiyat);
            DP.EXReturn("SergiEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("SergiNo", id);
            DP.EXReturn("SergiSil", param);
            return RedirectToAction("Index");
        }
    }
}