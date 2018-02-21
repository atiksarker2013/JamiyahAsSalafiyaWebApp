using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class AcademicController : BaseController
    {
        // GET: Academic
        public ActionResult Courses()
        {
            Academic model = new Academic();
            return View(model);
        }

        public ActionResult MonthlyExpenses()
        {
            Academic model = new Academic();
            return View(model);
        }

        public ActionResult Syllabus()
        {
            Academic model = new Academic();
            return View(model);
        }

        public ActionResult AcademicExam()
        {
            Academic model = new Academic();
            return View(model);
        }

        public ActionResult ClassRoutine()
        {
            Academic model = new Academic();
            return View(model);
        }

        public ActionResult AcademicCalender()
        {
            Academic model = new Academic();
            return View(model);
        }

        public ActionResult Result()
        {
            Academic model = new Academic();
            return View(model);
        }
    }
}