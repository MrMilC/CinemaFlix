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
    
    public partial class Terem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terem()
        {
            this.Eloadas = new HashSet<Eloadas>();
        }
    
        public short TeremID { get; set; }
        public string TeremNev { get; set; }
        public decimal UlesekSzama { get; set; }
        public byte MoziFK { get; set; }
        public bool Borfotel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eloadas> Eloadas { get; set; }
        public virtual Mozi Mozi { get; set; }
    }
}