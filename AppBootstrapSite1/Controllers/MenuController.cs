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

        public ActionResult OurStory(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("OurStoryEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("OurStoryArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("OurStoryBangla", null);
            }

            else
            {
                return PartialView("OurStoryEnglish", null);
            }

        }

        public ActionResult AademicInformation(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("AademicInformationEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("AademicInformationArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("AademicInformationBangla", null);
            }

            else
            {
                return PartialView("AademicInformationEnglish", null);
            }

        }

        public ActionResult DirectorCorner(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("DirectorsCornerEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("DirectorsCornerArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("DirectorsCornerBangla", null);
            }

            else
            {
                return PartialView("DirectorsCornerEnglish", null);
            }

        }

        public ActionResult AdmissionProcess(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("AdmissionProcessEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("AdmissionProcessArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("AdmissionProcessBangla", null);
            }

            else
            {
                return PartialView("AdmissionProcessEnglish", null);
            }

        }

        public ActionResult RulesAndRegulation(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("RulesAndRegulationEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("RulesAndRegulationArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("RulesAndRegulationBangla", null);
            }

            else
            {
                return PartialView("RulesAndRegulationEnglish", null);
            }

        }

        public ActionResult StudentsIdentity(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("StudentsIdentityEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("StudentsIdentityArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("StudentsIdentityBangla", null);
            }

            else
            {
                return PartialView("StudentsIdentityEnglish", null);
            }

        }

        public ActionResult CoCurricularActivities(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("CoCurricularActivitiesEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("CoCurricularActivitiesArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("CoCurricularActivitiesBangla", null);
            }

            else
            {
                return PartialView("CoCurricularActivitiesEnglish", null);
            }

        }

        public ActionResult SpecialEvents(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("SpecialEventsEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("SpecialEventsArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("SpecialEventsBangla", null);
            }

            else
            {
                return PartialView("SpecialEventsEnglish", null);
            }

        }

        public ActionResult NoticeBoard(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("NoticeBoardEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("NoticeBoardArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("NoticeBoardBangla", null);
            }

            else
            {
                return PartialView("NoticeBoardEnglish", null);
            }

        }

        public ActionResult Facilities(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("FacilitiesEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("FacilitiesArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("FacilitiesBangla", null);
            }

            else
            {
                return PartialView("FacilitiesEnglish", null);
            }

        }

        public ActionResult PrizesAndAchievements(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("PrizesAndAchievementsEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("PrizesAndAchievementsArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("PrizesAndAchievementsBangla", null);
            }

            else
            {
                return PartialView("PrizesAndAchievementsEnglish", null);
            }

        }

        public ActionResult MonthlyAlEtisam(string name)
        {
            string lang = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                lang = langCookie.Value;
            }
            if (lang == "En")
            {
                return PartialView("MonthlyAlEtisamEnglish", null);
            }
            if (lang == "Ar")
            {
                return PartialView("MonthlyAlEtisamArabic", null);
            }

            if (lang == "Bn")
            {
                return PartialView("MonthlyAlEtisamBangla", null);
            }

            else
            {
                return PartialView("MonthlyAlEtisamEnglish", null);
            }

        }


    }
}