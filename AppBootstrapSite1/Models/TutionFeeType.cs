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
    
    public partial class TutionFeeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TutionFeeType()
        {
            this.MonthlyTutionFee = new HashSet<MonthlyTutionFee>();
        }
    
        public int Id { get; set; }
        public string TutionFeeType1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthlyTutionFee> MonthlyTutionFee { get; set; }
    }
}
