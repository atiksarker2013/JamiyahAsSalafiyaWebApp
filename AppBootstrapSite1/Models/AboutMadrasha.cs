using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class AboutMadrasha
    {
        [Display(Name = "OurMadrasha", ResourceType = typeof(Resource))]
        public string OurMadrasha
        {
            get;
            set;
        }

        [Display(Name = "OurMadrashaModelHeading", ResourceType = typeof(Resource))]
        public string OurMadrashaModelHeading
        {
            get;
            set;
        }

        [Display(Name = "OurSuccess", ResourceType = typeof(Resource))]
        public string OurSuccess
        {
            get;
            set;
        }

        [Display(Name = "OurSuccessHeading", ResourceType = typeof(Resource))]
        public string OurSuccessHeading
        {
            get;
            set;
        }

        [Display(Name = "MadrashaCharacteristics", ResourceType = typeof(Resource))]
        public string MadrashaCharacteristics
        {
            get;
            set;
        }

        [Display(Name = "MadrashaCharacteristicsHeading", ResourceType = typeof(Resource))]
        public string MadrashaCharacteristicsHeading
        {
            get;
            set;
        }
    }
}