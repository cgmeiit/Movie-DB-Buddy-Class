//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Rental
    {
        [Key]
        public int RentalID { get; set; }
        public Nullable<int> CustID { get; set; }
        public Nullable<int> MovieID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Movy Movy { get; set; }
    }
}
