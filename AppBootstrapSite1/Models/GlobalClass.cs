using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppBootstrapSite1.Models
{
    public class GlobalClass
    {
        static private string _ModuleList = "ModuleList";
        public static List<UserModuleClass> ModuleList
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._ModuleList] == null)
                {
                    return null;
                }
                else
                {
                    return (List<UserModuleClass>)(HttpContext.Current.Session[GlobalClass._ModuleList]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._ModuleList] = value;
            }
        }
        static private string _FormList = "FormList";
        public static List<UserFormClass> FormList
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._FormList] == null)
                {
                    return null;
                }
                else
                {
                    return (List<UserFormClass>)(HttpContext.Current.Session[GlobalClass._FormList]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._FormList] = value;
            }
        }
        static private string _MasterSession = "MasterSession";
        public static bool MasterSession
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._MasterSession] == null)
                {
                    return false;
                }
                else
                {
                    return (bool)(HttpContext.Current.Session[GlobalClass._MasterSession]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._MasterSession] = value;
            }
        }

      
        static private string _LoginUser = "LoginUser";
        public static StaffList LoginUser
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._LoginUser] == null)
                {
                    return null;
                }
                else
                {
                    return (StaffList)(HttpContext.Current.Session[GlobalClass._LoginUser]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._LoginUser] = value;
            }
        }
        static private string _ProfileUser = "ProfileUser";
        public static UserProfile ProfileUser
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._ProfileUser] == null)
                {
                    return null;
                }
                else
                {
                    return (UserProfile)(HttpContext.Current.Session[GlobalClass._ProfileUser]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._ProfileUser] = value;
            }
        }

        static private string _LoggedInUser = "LoggedInUser";
        public static UserProfile LoggedInUser
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._LoggedInUser] == null)
                {
                    return null;
                }
                else
                {
                    return (UserProfile)(HttpContext.Current.Session[GlobalClass._LoggedInUser]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._LoggedInUser] = value;
            }
        }

        static private string _IsSubArea = "IsSubArea";
        public static bool IsSubArea
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._IsSubArea] == null)
                {
                    return false;
                }
                else
                {
                    return (bool)(HttpContext.Current.Session[GlobalClass._IsSubArea]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._IsSubArea] = value;
            }
        }
        static private string _SubAreaLevel = "SubAreaLevel";
        public static int SubAreaLevel
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._SubAreaLevel] == null)
                {
                    return -99;
                }
                else
                {
                    return (int)(HttpContext.Current.Session[GlobalClass._SubAreaLevel]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._SubAreaLevel] = value;
            }
        }
      

        static private string _AreaGuidForSubArea = "AreaGuidForSubArea";
        public static Guid AreaGuidForSubArea
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._AreaGuidForSubArea] == null)
                {
                    return Guid.Empty;
                }
                else
                {
                    return (Guid)(HttpContext.Current.Session[GlobalClass._AreaGuidForSubArea]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._AreaGuidForSubArea] = value;
            }
        }
        static private string _AreaHeading = "AreaHeading";
        public static string AreaHeading
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._AreaHeading] == null)
                {
                    return null;
                }
                else
                {
                    return (string)(HttpContext.Current.Session[GlobalClass._AreaHeading]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._AreaHeading] = value;
            }
        }

        static private string _ProposalGuid = "ProposalGuid";
        public static Guid ProposalGuid
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._ProposalGuid] == null)
                {
                    return Guid.Empty;
                }
                else
                {
                    return (Guid)(HttpContext.Current.Session[GlobalClass._ProposalGuid]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._ProposalGuid] = value;
            }
        }
    }
}