using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class DirectorCornerController : Controller
    {
        // GET: DirectorCorner
        public ActionResult DirectorIdentity()
        {
            return View();
        }

        public ActionResult DirectorMessage()
        {
            return View();
        }
    }
}