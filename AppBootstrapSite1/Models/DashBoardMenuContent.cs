using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class DashBoardMenuContent
    {
        [Display(Name = "OurMadrashaHeading", ResourceType = typeof(Resource))]
        public string OurMadrashaHeading
        {
            get;
            set;
        }

        [Display(Name = "OurMadrashaSubtitle", ResourceType = typeof(Resource))]
        public string OurMadrashaSubtitle
        {
            get;
            set;
        }

        [Display(Name = "OurMadrashaDetails", ResourceType = typeof(Resource))]
        public string OurMadrashaDetails
        {
            get;
            set;
        }


        [Display(Name = "AdmissionHeading", ResourceType = typeof(Resource))]
        public string AdmissionHeading
        {
            get;
            set;
        }


        [Display(Name = "AdmissionSubtitle", ResourceType = typeof(Resource))]
        public string AdmissionSubtitle
        {
            get;
            set;
        }

        [Display(Name = "AdmissionDetails", ResourceType = typeof(Resource))]
        public string AdmissionDetails
        {
            get;
            set;
        }


        [Display(Name = "NoticeHeading", ResourceType = typeof(Resource))]
        public string NoticeHeading
        {
            get;
            set;
        }


        [Display(Name = "NoticeSubtitle", ResourceType = typeof(Resource))]
        public string NoticeSubtitle
        {
            get;
            set;
        }

        [Display(Name = "NoticeDetails", ResourceType = typeof(Resource))]
        public string NoticeDetails
        {
            get;
            set;
        }

        [Display(Name = "WelcomeDetails", ResourceType = typeof(Resource))]
        public string WelcomeDetails
        {
            get;
            set;
        }

        [Display(Name = "WelcomeHeading", ResourceType = typeof(Resource))]
        public string WelcomeHeading
        {
            get;
            set;
        }


        [Display(Name = "JamiyahLifeHeading", ResourceType = typeof(Resource))]
        public string JamiyahLifeHeading
        {
            get;
            set;
        }

        [Display(Name = "JamiyahLifeDetails", ResourceType = typeof(Resource))]
        public string JamiyahLifeDetails
        {
            get;
            set;
        }

    }
}