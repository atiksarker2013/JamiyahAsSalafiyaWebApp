//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppBootstrapSite1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroupModule
    {
        public System.Guid UserGroupModuleKey { get; set; }
        public Nullable<System.Guid> UserGroupKey { get; set; }
        public Nullable<System.Guid> ModuleKey { get; set; }
    
        public virtual Modules Modules { get; set; }
        public virtual Usergroup Usergroup { get; set; }
    }
}
