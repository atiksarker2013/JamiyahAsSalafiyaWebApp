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
    
    public partial class UserProfile
    {
        public System.Guid ProfileKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> CityKey { get; set; }
        public Nullable<int> StateKey { get; set; }
        public string JobTitle { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<bool> UserStatus { get; set; }
        public byte[] Photo { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public Nullable<System.Guid> RoleKey { get; set; }
        public string PhoneNo { get; set; }
        public string PrimaryBusinessType { get; set; }
        public string HireOutsideAuditor { get; set; }
        public string AnnualSalesRevenue { get; set; }
        public string SalesReach { get; set; }
        public string DirectManufacture { get; set; }
        public string DirectDistributor { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
