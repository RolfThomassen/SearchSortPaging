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
    
    public partial class vw_Co2Db_Korrespondance_all
    {
        public int ID { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> MedarbejderID { get; set; }
        public Nullable<int> Status { get; set; }
        public string Overskrift { get; set; }
        public Nullable<bool> Ekstern { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Mime { get; set; }
        public string Filename { get; set; }
        public string Ext { get; set; }
        public Nullable<int> Size { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
    }
}
