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
    
    public partial class vw_Co2Db_Incasso
    {
        public int ID { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusText { get; set; }
        public int CompanyID { get; set; }
        public int InvoiceID { get; set; }
        public Nullable<System.DateTime> IncassoDate { get; set; }
        public string Notes { get; set; }
        public Nullable<double> InvoiceTotal { get; set; }
        public Nullable<double> RenterOpgjortAfKreditor { get; set; }
        public Nullable<double> GebyrOpgjortAfKreditor { get; set; }
        public Nullable<double> RenteTilskrevetFraPaymentDatetilDD { get; set; }
        public Nullable<double> GebyrForDenneRykkerskrivelse { get; set; }
        public Nullable<double> IncassoTotal { get; set; }
        public Nullable<double> IncassoSalaer { get; set; }
        public Nullable<double> Oversendelsesgebyr { get; set; }
        public string OprettetAf { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public Nullable<bool> Paid { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public Nullable<int> InvoiceStatus { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public string PaymentTerms { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<int> ResponsibleID { get; set; }
        public string ResponsibleName { get; set; }
        public Nullable<System.Guid> ResponsibleGUID { get; set; }
        public string InvoiceContactName { get; set; }
        public string InvoiceContactEmail { get; set; }
        public string InvoiceNotes { get; set; }
        public string InvoiceEANno { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceAddress1 { get; set; }
        public string InvoiceAddress2 { get; set; }
        public string InvoiceZipCode { get; set; }
        public string InvoiceCity { get; set; }
        public string InvoiceState { get; set; }
        public string InvoiceCountry { get; set; }
        public string InvoiceAtt { get; set; }
        public string InvoiceRef { get; set; }
        public string DeleveryEANno { get; set; }
        public string DeleveryName { get; set; }
        public string DeleveryAddress1 { get; set; }
        public string DeleveryAddress2 { get; set; }
        public string DeleveryZipCode { get; set; }
        public string DeleveryCity { get; set; }
        public string DeleveryState { get; set; }
        public string DeleveryCountry { get; set; }
        public string DeleveryAtt { get; set; }
        public string DeleveryRef { get; set; }
        public Nullable<int> InvoiceLines { get; set; }
        public Nullable<int> InvoiceLineItems { get; set; }
        public Nullable<double> InvoiceLinesTotal { get; set; }
        public Nullable<double> InvoiceTransport { get; set; }
        public Nullable<double> InvoiceVAT { get; set; }
        public Nullable<double> InvoiceTotalInclVAT { get; set; }
        public Nullable<bool> InvoicePaid { get; set; }
        public Nullable<System.DateTime> InvoicePaidDate { get; set; }
        public string OrderNo { get; set; }
        public string YourRef { get; set; }
        public Nullable<int> CreditnoteID { get; set; }
        public Nullable<int> KundeGrpID { get; set; }
        public string Cvrnr { get; set; }
        public string Firmanavn { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Postnr { get; set; }
        public string Bynavn { get; set; }
        public string State { get; set; }
        public string Land { get; set; }
        public string EANnr { get; set; }
        public Nullable<int> LandekodeID { get; set; }
        public Nullable<System.Guid> AgentID { get; set; }
        public Nullable<double> TotalItemPrice { get; set; }
        public Nullable<double> TotalDiscountPrice { get; set; }
        public Nullable<double> TotalSalesPrice { get; set; }
        public Nullable<double> InvoiceProvision { get; set; }
        public Nullable<bool> VATfree { get; set; }
        public Nullable<bool> EANInvoice { get; set; }
        public Nullable<int> IncassoID { get; set; }
    }
}
