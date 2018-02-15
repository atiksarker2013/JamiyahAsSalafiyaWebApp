using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //DashBoardMenuContent model = new DashBoardMenuContent();
            //model.OurMadrashaHeading = "";
            ViewBag.Title = "Jamiah As Salafiyah";
            return View();
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageMang().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }
    }


}