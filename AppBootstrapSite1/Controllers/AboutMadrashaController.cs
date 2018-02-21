using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class AboutMadrashaController : BaseController
    {
        // GET: AboutMadrasha
        public ActionResult OurMadrasha()
        {
            AboutMadrasha model = new AboutMadrasha();
            return View(model);
        }

        public ActionResult OurSuccess()
        {
            AboutMadrasha model = new AboutMadrasha();
            return View(model);
        }

        public ActionResult MadrashaCharacteristics()
        {
            AboutMadrasha model = new AboutMadrasha();
            return View(model);
        }
    }
}