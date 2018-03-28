using AppBootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class HomeController : BaseController
    {
        private JamiyahDBEntities db = new JamiyahDBEntities();
        public ActionResult Index()
        {
             DashBoardMenuContent model = new DashBoardMenuContent();
            //model.OurMadrashaHeading = "";
            ViewBag.Title = "Jamiah As Salafiyah";
            return View(model);
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageMang().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            LoginViewModel model = new LoginViewModel();
            if (Request.Cookies["UserLogin"] != null)
            {
                model.Username = Request.Cookies["UserLogin"].Values["Username"];
                model.Password = Request.Cookies["UserLogin"].Values["Password"];
            }
            return View(model);
        }

        public ActionResult MainDashBoard()
        {
            return View();
            //if (GlobalClass.MasterSession)
            //{
            //    return View();
            //}
            //else
            //{
            //    Exception e = new Exception("Sorry, your Session has Expired");
            //    return View("Error", new HandleErrorInfo(e, "Home", "Login"));
            //}
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {

            try
            {
               StaffList obj = db.StaffList.SingleOrDefault(m => m.Username == model.Username && m.Password == model.Password && m.IsDelete == false && m.IsUser == true);
                if (obj == null)
                {
                    Exception e = new Exception("Incorrect user access. Unauthorized Access.");
                    return View("Error", new HandleErrorInfo(e, "Home", "Login"));
                }
                else
                {
                    if (model.RememberMe)
                    {
                        HttpCookie cookie = new HttpCookie("UserLogin");
                        cookie.Values.Add("Username", model.Username);
                        cookie.Values.Add("Password", model.Password);
                        cookie.Expires = DateTime.Now.AddDays(715);
                        Response.Cookies.Add(cookie);

                    }
                    GlobalClass.MasterSession = true;
                    GlobalClass.LoginUser = obj;
                    EM.EM_AdminAccess.SetUserAccess((Guid)obj.Usergr);
                    GlobalClass.Company = db.Company.SingleOrDefault(m => m.CompanyKey == obj.CompanyKey);
                    return RedirectToAction("MainDashBoard", "Home");
                }

            }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "Home", "Login"));
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }


}