using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppBootstrapSite1.Models;

namespace AppBootstrapSite1.Controllers
{
    public class PendingAssignStudentController : Controller
    {
        private JamiyahDBEntities db = new JamiyahDBEntities();

        // GET: PendingAssignStudent
        public ActionResult Index()
        {
            var studentInfo = db.StudentInfo.Include(s => s.Company).Include(s => s.Department).Include(s => s.Gender);
            return View(studentInfo.ToList());
        }

        // GET: PendingAssignStudent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            if (studentInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentInfo);
        }

        // GET: PendingAssignStudent/Create
        public ActionResult Create()
        {
            ViewBag.Brach = new SelectList(db.Company, "CompanyKey", "CompanyID");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name");
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName");
            return View();
        }

        // POST: PendingAssignStudent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentPhoto,StudentNameBangla,StudentNameEnglish,StudentNameArabic,StudentDateOfBirth,GenderId,Nationality,FatherNameBangla,FatherNameEnglish,FatherIsAlive,FatherOccupation,FatherMobile,MotherNameBangla,MotherNameEnglish,MotherIsAlive,MotherMobile,GuardianName,GuardianOccupation,GuardianHouseNo,GuardianVillage,GuardianPostOffice,GuardianThana,GuardianDistrict,RelationWithGuardian,YearlyIncomeGuardian,PermanentAddressHouse,PermanentAddressVillage,PermanentAddressPostOffice,PermanentAddressThana,PermanentAddressDistrict,HonarablePersonNameInArea,PreviousInstitutionName,PreviousInstitutionAddress,PreviousInstitutionClass,PreviousInstitutionClearanceNo,PreviousInstitutionClearanceDate,AdmittedDepartmentId,IsAssign,Brach")] StudentInfo studentInfo)
        {
            if (ModelState.IsValid)
            {
                db.StudentInfo.Add(studentInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Brach = new SelectList(db.Company, "CompanyKey", "CompanyID", studentInfo.Brach);
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name", studentInfo.AdmittedDepartmentId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName", studentInfo.GenderId);
            return View(studentInfo);
        }

        // GET: PendingAssignStudent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            if (studentInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.Brach = new SelectList(db.Company, "CompanyKey", "CompanyID", studentInfo.Brach);
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name", studentInfo.AdmittedDepartmentId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName", studentInfo.GenderId);
            return View(studentInfo);
        }

        // POST: PendingAssignStudent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentPhoto,StudentNameBangla,StudentNameEnglish,StudentNameArabic,StudentDateOfBirth,GenderId,Nationality,FatherNameBangla,FatherNameEnglish,FatherIsAlive,FatherOccupation,FatherMobile,MotherNameBangla,MotherNameEnglish,MotherIsAlive,MotherMobile,GuardianName,GuardianOccupation,GuardianHouseNo,GuardianVillage,GuardianPostOffice,GuardianThana,GuardianDistrict,RelationWithGuardian,YearlyIncomeGuardian,PermanentAddressHouse,PermanentAddressVillage,PermanentAddressPostOffice,PermanentAddressThana,PermanentAddressDistrict,HonarablePersonNameInArea,PreviousInstitutionName,PreviousInstitutionAddress,PreviousInstitutionClass,PreviousInstitutionClearanceNo,PreviousInstitutionClearanceDate,AdmittedDepartmentId,IsAssign,Brach")] StudentInfo studentInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Brach = new SelectList(db.Company, "CompanyKey", "CompanyID", studentInfo.Brach);
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name", studentInfo.AdmittedDepartmentId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName", studentInfo.GenderId);
            return View(studentInfo);
        }

        // GET: PendingAssignStudent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            if (studentInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentInfo);
        }

        // POST: PendingAssignStudent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            db.StudentInfo.Remove(studentInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
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
