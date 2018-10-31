using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBootstrapSite1.Models;

namespace AppBootstrapSite1.Controllers
{
    public class MonthlyAlEtisamController : BaseController
    {
        // GET: MonthlyAlEtisam
        public ActionResult Introduction()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Characteristics()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }
    }
}