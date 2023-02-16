using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyu_proje10_.Models;

namespace Yoyu_proje10_.Controllers
{
    public class SanatciController : Controller
    {
        // GET: Sanatci
        public ActionResult Index()
        {
            return View(DP.ReturnList<SanatciModel>("SanatciListele"));
        }

        public ActionResult EY(int id = 0) //ekle yenile
        {
            if (id == 0)

                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SanatciNo", id);
                return View(DP.ReturnList<SanatciModel>("SanatciSirala", param).FirstOrDefault<SanatciModel>());
            }

        }
        [HttpPost]
        public ActionResult EY(SanatciModel sanatci)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SanatciNo", sanatci.SanatciNo);
            param.Add("@SanatciAdi", sanatci.SanatciAdi);
            param.Add("@SanatciSoyadi", sanatci.SanatciSoyadi);
            param.Add("@SanatciDogumTarihi", sanatci.SanatciDogumTarihi);
            param.Add("@SanatciAdres", sanatci.SanatciAdres);
            param.Add("@SanatciTelefon", sanatci.SanatciTelefon);
            param.Add("@SanatciDeneyimYil", sanatci.SanatciDeneyimYil);
            param.Add("@SergiNo", sanatci.SergiNo);
            DP.EXReturn("SanatciEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("SanatciNo", id);
            DP.EXReturn("SanatciSil", param);
            return RedirectToAction("Index");
        }
    }
}