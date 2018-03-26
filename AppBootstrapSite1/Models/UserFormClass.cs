using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class UserFormClass
    {
        public Guid? FormID { get; set; }
        public Guid? ModuleID { get; set; }
        public string FormName { get; set; }
        public Nullable<int> FormLevel { get; set; }
        public string FormController { get; set; }
        public string FormView { get; set; }
        public string FormCss { get; set; }
    }
}