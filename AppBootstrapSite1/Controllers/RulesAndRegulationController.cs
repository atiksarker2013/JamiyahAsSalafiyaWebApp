using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class RulesAndRegulationController : BaseController
    {
        // GET: RulesAndRegulation
        public ActionResult Discipline()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ClassAndHoliDaySchedule()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Uniform()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ListOfExam()
        {
            return View();
        }

        public ActionResult MonthlyFees()
        {
            return View();
        }


        public ActionResult OtherFees()
        {
            return View();
        }

        public ActionResult Fine()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }


    }
}