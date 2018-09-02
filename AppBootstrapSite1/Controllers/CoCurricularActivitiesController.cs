using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBootstrapSite1.Models;

namespace AppBootstrapSite1.Controllers
{
    public class CoCurricularActivitiesController : BaseController
    {
        // GET: CoCurricularActivities
        public ActionResult TrainingForDeliveringSpeech()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult QuranStudyAndResearchFourm()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }


        public ActionResult HadithStudyAndResearchFourm()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult DebatingClub()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult IslamicQuizClub()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult GeneralQuizClub()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult IslamicSongClub()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }
    }
}