//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class semester
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public semester()
        {
            this.documentstores = new HashSet<documentstore>();
        }
    
        public int id { get; set; }
        public int session_id { get; set; }
        public string semester_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentstore> documentstores { get; set; }
        public virtual session session { get; set; }
    }
}
