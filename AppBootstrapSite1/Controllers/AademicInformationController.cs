using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class AademicInformationController : BaseController
    {
        // GET: AademicInformation
        public ActionResult Curriculum()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ClassRoutine()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ExaminationSchedule()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Primary()
        {
            return View();
        }

        public ActionResult Secondary()
        {
            return View();
        }

        public ActionResult HigherSecondary()
        {
            return View();
        }

        public ActionResult HigherEducation()
        {
            return View();
        }
    }
}