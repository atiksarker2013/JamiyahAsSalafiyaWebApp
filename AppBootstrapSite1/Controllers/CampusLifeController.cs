using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class CampusLifeController : BaseController
    {
        // GET: CampusLife
        public ActionResult DressCode()
        {
            CampusLife model = new CampusLife();
            return View(model);
        }

        public ActionResult DailyMeal()
        {
            CampusLife model = new CampusLife();
            return View(model);
        }

        public ActionResult StudentRegulation()
        {
            CampusLife model = new CampusLife();
            return View(model);
        }

        public ActionResult StudentResidentialConvention()
        {
            CampusLife model = new CampusLife();
            return View(model);
        }

        public ActionResult WeeklyPersonalTraining()
        {
            CampusLife model = new CampusLife();
            return View(model);
        }

        public ActionResult StudentLists()
        {
            CampusLife model = new CampusLife();
            return View(model);
        }
    }
}