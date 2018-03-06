using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class NoticeBoardController : Controller
    {
        // GET: NoticeBoard
        public ActionResult NoticeForStudent()
        {
            return View();
        }

        public ActionResult AdvertisementForAppointment()
        {
            return View();
        }

        public ActionResult TenderNotice()
        {
            return View();
        }
    }
}