//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaFlix
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.Eloadas = new HashSet<Eloadas>();
        }
    
        public byte FilmID { get; set; }
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public decimal Hossz_percben { get; set; }
        public string Besorolas { get; set; }
        public decimal MegjelenesEve { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eloadas> Eloadas { get; set; }
    }
}
