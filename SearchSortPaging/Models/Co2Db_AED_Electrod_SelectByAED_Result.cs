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
    
    public partial class Co2Db_AED_Electrod_SelectByAED_Result
    {
        public int ID { get; set; }
        public int AED_FK { get; set; }
        public int ElectrodType { get; set; }
        public string ElectrodTypeText { get; set; }
        public Nullable<System.DateTime> ElectrodDeleveryDate { get; set; }
        public Nullable<System.DateTime> ElectrodExpireDate { get; set; }
        public Nullable<System.DateTime> ElectrodEmailSendt { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusText { get; set; }
        public string OprettetAf { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<System.Guid> AgentID { get; set; }
        public string StatusText1 { get; set; }
    }
}
