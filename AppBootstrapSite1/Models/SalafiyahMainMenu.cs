using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class SalafiyahMainMenu
    {
        [Display(Name = "MainMenuName", ResourceType = typeof(Resource))]
        public string FirstName
        {
            get;
            set;
        }
    }
}