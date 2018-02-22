using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class Administrative
    {
        [Display(Name = "Chairman", ResourceType = typeof(Resource))]
        public string Chairman
        {
            get;
            set;
        }

        [Display(Name = "ChairmanHeading", ResourceType = typeof(Resource))]
        public string ChairmanHeading
        {
            get;
            set;
        }

        [Display(Name = "Principal", ResourceType = typeof(Resource))]
        public string Principal
        {
            get;
            set;
        }

        [Display(Name = "PrincipalHeading", ResourceType = typeof(Resource))]
        public string PrincipalHeading
        {
            get;
            set;
        }

        [Display(Name = "VicePrincipal", ResourceType = typeof(Resource))]
        public string VicePrincipal
        {
            get;
            set;
        }

        [Display(Name = "VicePrincipalHeading", ResourceType = typeof(Resource))]
        public string VicePrincipalHeading
        {
            get;
            set;
        }

        [Display(Name = "TeacherStudentComitte", ResourceType = typeof(Resource))]
        public string TeacherStudentComitte
        {
            get;
            set;
        }

        [Display(Name = "TeacherStudentComitteHeading", ResourceType = typeof(Resource))]
        public string TeacherStudentComitteHeading
        {
            get;
            set;
        }

        [Display(Name = "ParentalResponsiblity", ResourceType = typeof(Resource))]
        public string ParentalResponsiblity
        {
            get;
            set;
        }

        [Display(Name = "ParentalResponsiblityHeading", ResourceType = typeof(Resource))]
        public string ParentalResponsiblityHeading
        {
            get;
            set;
        }
    }
}