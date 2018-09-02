using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBootstrapSite1.Models;

namespace AppBootstrapSite1.Controllers
{
    public class StudentsIdentityController : BaseController
    {
        // GET: StudentsIdentity
        public ActionResult PresentAndAbsence()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult StudentIdentityAndPassword()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ApplicationForLeaveOfAbsent()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ApplicationForRenuwalIDCard()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ApplicationForResettlement()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ApplicationForRecheckAnswerSheet()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult ApplicationForCorrectionNameAndDateOfBirth()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult VottingForFoodAndOther()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }



    }
}