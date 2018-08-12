using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class OurStoryController : BaseController
    {
        // GET: OurStory
        public ActionResult HistoryOfInstitution()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult AtAGlance()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult BordOfGovernor()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Location()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ListOfTeacherAndEmployee()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Principal()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult VicePrincipal()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult TeacherOfHigherEducation()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult TeacherOfSecondaryLabel()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult TeacherOfPrimaryLabel()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult TeacherOfHifzBranch()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Employee()
        {
            return View();
        }
    }
}