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
    
    public partial class Co2Db_FirstAidBag_Service_SelectID_Result
    {
        public int ID { get; set; }
        public int FAB_FK { get; set; }
        public string ServiceTypeText { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> ServiceType { get; set; }
        public Nullable<bool> ServiceActive { get; set; }
        public Nullable<System.DateTime> ServiceDueDate { get; set; }
        public Nullable<System.DateTime> ServiceVisitedDate { get; set; }
        public Nullable<int> ServiceConsultantID { get; set; }
        public string ServiceConsultant { get; set; }
        public Nullable<decimal> ServicePrice { get; set; }
        public string OprettetAf { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<System.Guid> AgentID { get; set; }
    }
}
