using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class AdministrativeController : Controller
    {
        // GET: Administrative
        public ActionResult Chairman()
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

        public ActionResult TeacherStudentComitte()
        {
            return View();
        }

        public ActionResult ParentalResponsiblity()
        {
            return View();
        }
    }
}