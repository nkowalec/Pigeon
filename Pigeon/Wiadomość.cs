//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pigeon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wiadomość
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wiadomość()
        {
            this.AdresaciDW = new HashSet<AdresatDW>();
        }
    
        public int Id { get; set; }
    
        public virtual Kontakt Adresat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdresatDW> AdresaciDW { get; set; }
    }
}
