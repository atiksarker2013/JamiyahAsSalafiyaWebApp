using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBootstrapSite1.Models;

namespace AppBootstrapSite1.Controllers
{
    public class SpecialEventsController : BaseController
    {
        // GET: SpecialEvents
        public ActionResult TrainingAndSeminar()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult GamesAndSports()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Picnic()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult Farewell()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        //public ActionResult FestivalReception()
        //{
        //    DashBoardMenuContent model = new DashBoardMenuContent();
        //    return View(model);
        //}

        public ActionResult QuranMahfil()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }
    }
}