using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBootstrapSite1.Models;

namespace AppBootstrapSite1.Controllers
{
    public class FacilitiesController : BaseController
    {
        // GET: Facilities
        public ActionResult PrimaryTreatment()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult DailyPaperAndMonthlyJournal()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult InternetBrowsing()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Library()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }
    }
}