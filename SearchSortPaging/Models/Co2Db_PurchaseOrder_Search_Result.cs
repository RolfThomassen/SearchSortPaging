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
    
    public partial class Co2Db_PurchaseOrder_Search_Result
    {
        public int ID { get; set; }
        public Nullable<int> Status { get; set; }
        public string OrderCreatedBy { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string SupplierEmail { get; set; }
        public string PurchaseOrderEmailCopy { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public string PaymentTerm { get; set; }
        public string PaymentCalc { get; set; }
        public string PaymentText { get; set; }
        public Nullable<int> FreightID { get; set; }
        public string FreightTitle { get; set; }
        public string FreightText { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> FreightPrice { get; set; }
        public Nullable<double> FreightPct { get; set; }
        public Nullable<decimal> TotalPurchaseOrder { get; set; }
        public Nullable<int> KundeGrpID { get; set; }
        public string Cvrnr { get; set; }
        public string Firmanavn { get; set; }
        public Nullable<System.Guid> AgentID { get; set; }
        public string AgentName { get; set; }
        public Nullable<double> PurchaseOrder_LineTotal { get; set; }
        public Nullable<decimal> PurchaseOrder_LinePrice { get; set; }
        public string OprettetAF { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAF { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public string ShipToEANno { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToZipCode { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToAtt { get; set; }
        public string ShipToRef { get; set; }
    }
}
