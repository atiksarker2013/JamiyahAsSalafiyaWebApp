﻿using AppBootstrapSite1.Models;
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
            return View();
        }

        public ActionResult Location()
        {
            return View();
        }

        public ActionResult ListOfTeacherAndEmployee()
        {
            return View();
        }

        public ActionResult Principal()
        {
            return View();
        }

        public ActionResult VicePrincipal()
        {
            return View();
        }

        public ActionResult TeacherOfHigherEducation()
        {
            return View();
        }

        public ActionResult TeacherOfSecondaryLabel()
        {
            return View();
        }

        public ActionResult TeacherOfPrimaryLabel()
        {
            return View();
        }

        public ActionResult TeacherOfHifzBranch()
        {
            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }
    }
}