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
    
    public partial class Co2Db_KursusDag_SelectAll_Result
    {
        public int ID { get; set; }
        public int KursusPolicyID { get; set; }
        public Nullable<System.DateTime> KursusDato { get; set; }
        public Nullable<bool> Repetionskursus { get; set; }
        public Nullable<int> Status { get; set; }
        public string OprettetAf { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
    }
}