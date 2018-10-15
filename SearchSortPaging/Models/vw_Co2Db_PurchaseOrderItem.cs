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
    
    public partial class vw_Co2Db_PurchaseOrderItem
    {
        public Nullable<int> SupplierID { get; set; }
        public int ID { get; set; }
        public int PurchaseOrderID { get; set; }
        public Nullable<int> Pos { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusText { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        public string SupplierItemID { get; set; }
        public string SupplierItemName { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> ItemPrice { get; set; }
        public Nullable<decimal> LinePrice { get; set; }
        public Nullable<double> LineTotal { get; set; }
        public Nullable<decimal> PurchaseOrder_TotalPrice { get; set; }
        public Nullable<System.DateTime> ExpectedReceiptDate { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public string OprettetAF { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAF { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public Nullable<double> PurchaseOrder_LineTotal { get; set; }
        public Nullable<int> PurchaseOrder_Status { get; set; }
        public string Firmanavn { get; set; }
        public string AgentName { get; set; }
    }
}
