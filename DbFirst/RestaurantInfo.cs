//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestaurantInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantInfo()
        {
            this.ReviewerInfoes = new HashSet<ReviewerInfo>();
        }
    
        public int restaurauntId { get; set; }
        public string RestaurauntName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReviewerInfo> ReviewerInfoes { get; set; }
    }
}
