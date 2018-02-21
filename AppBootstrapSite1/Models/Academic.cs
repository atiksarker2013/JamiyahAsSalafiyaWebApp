using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class Academic
    {
        [Display(Name = "CoursesDetails", ResourceType = typeof(Resource))]
        public string CoursesDetails
        {
            get;
            set;
        }

        [Display(Name = "CoursesDetailsHeading", ResourceType = typeof(Resource))]
        public string CoursesDetailsHeading
        {
            get;
            set;
        }

        [Display(Name = "MonthlyExpenses", ResourceType = typeof(Resource))]
        public string MonthlyExpenses
        {
            get;
            set;
        }

        [Display(Name = "MonthlyExpensesHeading", ResourceType = typeof(Resource))]
        public string MonthlyExpensesHeading
        {
            get;
            set;
        }

        [Display(Name = "Syllabus", ResourceType = typeof(Resource))]
        public string Syllabus
        {
            get;
            set;
        }

        [Display(Name = "SyllabusHeading", ResourceType = typeof(Resource))]
        public string SyllabusHeading
        {
            get;
            set;
        }

        [Display(Name = "AcademicExam", ResourceType = typeof(Resource))]
        public string AcademicExam
        {
            get;
            set;
        }

        [Display(Name = "AcademicExamHeading", ResourceType = typeof(Resource))]
        public string AcademicExamHeading
        {
            get;
            set;
        }

        [Display(Name = "ClassRoutine", ResourceType = typeof(Resource))]
        public string ClassRoutine
        {
            get;
            set;
        }

        [Display(Name = "ClassRoutineHeading", ResourceType = typeof(Resource))]
        public string ClassRoutineHeading
        {
            get;
            set;
        }

        [Display(Name = "AcademicCalender", ResourceType = typeof(Resource))]
        public string AcademicCalender
        {
            get;
            set;
        }

        [Display(Name = "AcademicCalenderHeading", ResourceType = typeof(Resource))]
        public string AcademicCalenderHeading
        {
            get;
            set;
        }

        [Display(Name = "Result", ResourceType = typeof(Resource))]
        public string Result
        {
            get;
            set;
        }

        [Display(Name = "ResultHeading", ResourceType = typeof(Resource))]
        public string ResultHeading
        {
            get;
            set;
        }

    }
}