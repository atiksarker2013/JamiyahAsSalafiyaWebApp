using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class AdministrativeController : BaseController
    {
        // GET: Administrative
        public ActionResult Chairman()
        {
            Administrative model = new Administrative();
            return View(model);
        }

        public ActionResult Principal()
        {
            Administrative model = new Administrative();
            return View(model);
        }

        public ActionResult VicePrincipal()
        {
            Administrative model = new Administrative();
            return View(model);
        }

        public ActionResult TeacherStudentComitte()
        {
            Administrative model = new Administrative();
            return View(model);
        }

        public ActionResult ParentalResponsiblity()
        {
            Administrative model = new Administrative();
            return View(model);
        }
    }
}