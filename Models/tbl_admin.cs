//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarAB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_admin()
        {
            this.tbl_category = new HashSet<tbl_category>();
        }
    
        public int ad_id { get; set; }
        public string ad_username { get; set; }
        public string ad_password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_category> tbl_category { get; set; }
    }
}
