using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class UserModuleClass
    {
        public Guid? UserGroupModuleKey { get; set; }
        public Guid? UserGroupKey { get; set; }
        public Guid? ModuleKey { get; set; }
        public string ModuleName { get; set; }
        public int? Level { get; set; }
        public List<UserFormClass> formList { get; set; }
    }
}