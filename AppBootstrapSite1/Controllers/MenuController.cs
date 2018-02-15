using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBootstrapSite1.Controllers
{
    public class MenuController : BaseController
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderMainMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang== "En")
            {
                return PartialView("MainMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("MainMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("MainMenuBangla", null);
            }

            else
            {
                return PartialView("MainMenuEnglish", null);
            }
           
        }

        public ActionResult AboutMadrashaMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("AboutMadrashaMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("AboutMadrashaMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("AboutMadrashaMenuBangla", null);
            }

            else
            {
                return PartialView("AboutMadrashaMenuEnglish", null);
            }

        }

        public ActionResult AcademicMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("AcademicMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("AcademicMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("AcademicMenuBangla", null);
            }

            else
            {
                return PartialView("AcademicMenuEnglish", null);
            }

        }

        public ActionResult AdministrationMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("AdministrationMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("AdministrationMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("AdministrationMenuBangla", null);
            }

            else
            {
                return PartialView("AdministrationMenuEnglish", null);
            }

        }

        public ActionResult FacultiesMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("FacultiesMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("FacultiesMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("FacultiesMenuBangla", null);
            }

            else
            {
                return PartialView("FacultiesMenuEnglish", null);
            }

        }

        public ActionResult AboutStudentMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("AboutStudentMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("AboutStudentMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("AboutStudentMenuBangla", null);
            }

            else
            {
                return PartialView("AboutStudentMenuEnglish", null);
            }

        }

        public ActionResult NoticeMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("NoticeMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("NoticeMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("NoticeMenuBangla", null);
            }

            else
            {
                return PartialView("NoticeMenuEnglish", null);
            }

        }

        public ActionResult ContactMenu(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("ContractMenuEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("ContractMenuArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("ContractMenuBangla", null);
            }

            else
            {
                return PartialView("ContractMenuEnglish", null);
            }

        }


        //AdministrationMenuEnglish
    }
}