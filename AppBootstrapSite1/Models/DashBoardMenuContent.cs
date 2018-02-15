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
    }
}