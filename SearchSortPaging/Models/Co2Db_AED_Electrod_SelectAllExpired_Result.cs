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
    
    public partial class Co2Db_AED_Electrod_SelectAllExpired_Result
    {
        public int ID { get; set; }
        public int AED_FK { get; set; }
        public int CompanyID { get; set; }
        public int TypeID { get; set; }
        public string TypeText { get; set; }
        public string SerialNo { get; set; }
        public int ModelID { get; set; }
        public Nullable<System.DateTime> DeleveryDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<System.DateTime> EmailSendt { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> SendEmail { get; set; }
    }
}
