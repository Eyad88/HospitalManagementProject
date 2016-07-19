//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescribe
    {
        public int PrescribedId { get; set; }
        public Nullable<int> DrugId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> DateTimeId { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<System.DateTime> PrescribedTime { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
