using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class DirectorCornerController : BaseController
    {
        // GET: DirectorCorner
        public ActionResult DirectorIdentity()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }

        public ActionResult DirectorMessage()
        {
            DashBoardMenuContent model = new DashBoardMenuContent();
            return View(model);
        }
    }
}