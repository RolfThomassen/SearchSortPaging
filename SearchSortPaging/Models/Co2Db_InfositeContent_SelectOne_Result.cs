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
    
    public partial class Co2Db_InfositeContent_SelectOne_Result
    {
        public int ID { get; set; }
        public Nullable<bool> Aktiv { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public int Page_FK { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> PagePos { get; set; }
        public Nullable<int> Container_ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> TekstType { get; set; }
        public string Tekst { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string RettetAF { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
    }
}
