using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLiquid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TransferDemo()
        {
            return View();
        }


        public ActionResult BandejaTransferencias()
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

        public ActionResult Favoritos()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult TransferenciaExpress()
        {
            ViewBag.Message = "";

            return View();
        }

    }
}