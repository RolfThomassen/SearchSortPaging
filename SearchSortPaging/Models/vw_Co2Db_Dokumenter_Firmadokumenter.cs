//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SearchSortPaging.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Co2Db_Dokumenter_Firmadokumenter
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string Name { get; set; }
        public Nullable<int> Type { get; set; }
        public string TypeText { get; set; }
        public Nullable<int> Category { get; set; }
        public string CategoryText { get; set; }
        public Nullable<int> Owner { get; set; }
        public string OwnerText { get; set; }
        public Nullable<int> MedArbGrpID { get; set; }
        public string MedArbGrpText { get; set; }
        public string LeverandorAftaleNr { get; set; }
        public Nullable<bool> Aktiv { get; set; }
    }
}
