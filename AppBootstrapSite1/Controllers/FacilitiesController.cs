using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class FacilitiesController : Controller
    {
        // GET: Facilities
        public ActionResult PrimaryTreatment()
        {
            return View();
        }

        public ActionResult DailyPaperAndMonthlyJournal()
        {
            return View();
        }

        public ActionResult InternetBrowsing()
        {
            return View();
        }

        public ActionResult Library()
        {
            return View();
        }
    }
}