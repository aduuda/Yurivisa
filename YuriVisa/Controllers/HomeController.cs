using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YuriVisa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult FOREIGNER()
        {
            return View();
        }
        public ActionResult ISSUANCE()
        {
            return View();
        }
        public ActionResult EXTENSION()
        {
            return View();
        }
        public ActionResult APPLY()
        {
            return View();
        }
        public ActionResult TEMPORARY()
        {
            return View();
        }
        public ActionResult ForVietnamese()
        {
            return View();
        }
        public ActionResult TouristVisa()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Dulichhanquocdedang()
        {
            return View();
        }
        public ActionResult Huongdanhosovisahanquoctutuc()
        {
            return View();
        }
        public ActionResult lamthenaodehosohanquoc()
        {
            return View();
        }
        public ActionResult danhsachdenhanquoc()
        {
            return View();
        }
        public ActionResult thongbaovevisa10nam()
        {
            return View();
        }
        public ActionResult thongbaovevisamuoinam()
        {
            return View();
        }
        public ActionResult nenbookvemaybay()
        {
            return View();
        }
        public ActionResult ChucTet_VietHan()
        {
            return View();
        }
    }
}