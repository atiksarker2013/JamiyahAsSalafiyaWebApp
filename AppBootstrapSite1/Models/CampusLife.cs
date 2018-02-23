using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class CampusLife
    {

        [Display(Name = "DressCodeHeading", ResourceType = typeof(Resource))]
        public string DressCodeHeading
        {
            get;
            set;
        }


        [Display(Name = "DressCode", ResourceType = typeof(Resource))]
        public string DressCode
        {
            get;
            set;
        }

        [Display(Name = "DailyMeal", ResourceType = typeof(Resource))]
        public string DailyMeal
        {
            get;
            set;
        }

        [Display(Name = "DailyMealHeading", ResourceType = typeof(Resource))]
        public string DailyMealHeading
        {
            get;
            set;
        }

        [Display(Name = "StudentRegulation", ResourceType = typeof(Resource))]
        public string StudentRegulation
        {
            get;
            set;
        }

        [Display(Name = "StudentRegulationHeading", ResourceType = typeof(Resource))]
        public string StudentRegulationHeading
        {
            get;
            set;
        }


        [Display(Name = "StudentResidentialConvention", ResourceType = typeof(Resource))]
        public string StudentResidentialConvention
        {
            get;
            set;
        }

        [Display(Name = "StudentResidentialConventionHeading", ResourceType = typeof(Resource))]
        public string StudentResidentialConventionHeading
        {
            get;
            set;
        }


        [Display(Name = "WeeklyPersonalTraining", ResourceType = typeof(Resource))]
        public string WeeklyPersonalTraining
        {
            get;
            set;
        }

        [Display(Name = "WeeklyPersonalTrainingHeading", ResourceType = typeof(Resource))]
        public string WeeklyPersonalTrainingHeading
        {
            get;
            set;
        }


        [Display(Name = "StudentLists", ResourceType = typeof(Resource))]
        public string StudentLists
        {
            get;
            set;
        }


        [Display(Name = "StudentListsHeading", ResourceType = typeof(Resource))]
        public string StudentListsHeading
        {
            get;
            set;
        }
    }
}