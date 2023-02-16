using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyu_proje10_.Models;

namespace Yoyu_proje10_.Controllers
{
    public class SanatEseriController : Controller
    {
        // GET: SanatEseri
        public ActionResult Index()
        {
            return View(DP.ReturnList<SanatEseriModel>("SanatEseriListele")); 
        }

        public ActionResult EY(int id = 0) //ekle yenile
        {
            if (id == 0)

                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SanatEseriNo", id);
                return View(DP.ReturnList<SanatEseriModel>("SanatEseriSirala", param).FirstOrDefault<SanatEseriModel>());
            }

        }
        [HttpPost]
        public ActionResult EY(SanatEseriModel sanateseri)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SanatEseriNo", sanateseri.SanatEseriNo);
            param.Add("@SanatciNo", sanateseri.SanatciNo);
            param.Add("@SanatEseriAdi", sanateseri.SanatEseriAdi);
            param.Add("@SanatEseriTuru", sanateseri.SanatEseriTuru);
            param.Add("@SanatEseriYil", sanateseri.SanatEseriYil);
            param.Add("@SanatEseriFiyat", sanateseri.SanatEseriFiyat);
            DP.EXReturn("SanatEseriEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("SanatEseriNo", id);
            DP.EXReturn("SanatEseriSil", param);
            return RedirectToAction("Index");
        }
    }
}