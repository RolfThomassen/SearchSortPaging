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
    
    public partial class Co2DB_Campaign_Company_SelectCompanyID_Result
    {
        public int ID { get; set; }
        public int CampaignID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.Guid> ResponsibleID { get; set; }
        public string ResponsibleName { get; set; }
        public string ResponsibleEmail { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<bool> ContactedByPhone { get; set; }
        public Nullable<bool> MeetingHeld { get; set; }
        public Nullable<bool> CampaignSale { get; set; }
        public Nullable<decimal> CampaignSaleAmount { get; set; }
        public Nullable<bool> ExpectedSale { get; set; }
        public Nullable<decimal> ExpectedSaleAmount { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Historik { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> KundeGrpID { get; set; }
        public Nullable<int> ProfileType { get; set; }
        public string Cvrnr { get; set; }
        public string Firmanavn { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Postnr { get; set; }
        public string Bynavn { get; set; }
        public string State { get; set; }
        public Nullable<int> LandekodeID { get; set; }
        public string Land { get; set; }
        public Nullable<int> FirmastatusID { get; set; }
        public Nullable<int> AndetID { get; set; }
        public Nullable<int> SamArbejdspartner { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSiteUrl { get; set; }
        public string Noter { get; set; }
        public string BeslutNavn { get; set; }
        public string BeslutStilling { get; set; }
        public string BeslutTelefon { get; set; }
        public string BeslutMobil { get; set; }
        public string BeslutEmail { get; set; }
        public string AdminNavn { get; set; }
        public string AdminStilling { get; set; }
        public string AdminTelefon { get; set; }
        public string AdminMobil { get; set; }
        public string AdminEmail { get; set; }
        public Nullable<int> KundeStatusID { get; set; }
        public Nullable<System.DateTime> Ophortdato { get; set; }
        public Nullable<int> BetjeningsansvarligID { get; set; }
        public Nullable<int> AfdelingAPID { get; set; }
        public Nullable<int> DagligBetjenerAPID { get; set; }
        public Nullable<int> KontaktansvarligAPID { get; set; }
        public Nullable<int> SelskabID { get; set; }
        public Nullable<int> DagligBetjenerEksternID { get; set; }
        public Nullable<int> KontaktansvarligEksternID { get; set; }
        public Nullable<bool> MedlemDanskErhverv { get; set; }
        public Nullable<bool> MedlemGLSA { get; set; }
        public Nullable<int> BrancheForeningID { get; set; }
        public string EANnr { get; set; }
        public Nullable<System.Guid> AgentID { get; set; }
        public Nullable<System.DateTime> AgentStartDate { get; set; }
        public Nullable<System.DateTime> AgentExpiredDate { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<bool> FreightFree { get; set; }
        public Nullable<bool> VATfree { get; set; }
        public Nullable<bool> SendInvoiceViaEmail { get; set; }
        public string InvoiceEmail { get; set; }
        public Nullable<int> AEDsupplierID { get; set; }
        public string KundeStatusText { get; set; }
        public Nullable<bool> Supplier { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTitle { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierMobil { get; set; }
        public string SupplierEmail { get; set; }
        public Nullable<bool> AEDservice { get; set; }
        public Nullable<bool> WeberService { get; set; }
        public Nullable<System.DateTime> WS_AftaleDato { get; set; }
        public string WS_KontaktPerson { get; set; }
        public string WS_KontaktEmail { get; set; }
        public Nullable<System.DateTime> WS_LastServiceVisitDate { get; set; }
        public Nullable<System.DateTime> WS_NextServiceVisitDate { get; set; }
        public Nullable<System.DateTime> WS_ServiceVisitIn { get; set; }
        public Nullable<int> WS_ServicePeriods { get; set; }
        public Nullable<System.DateTime> WS_ServiceEmailSendt { get; set; }
        public Nullable<int> WS_ServiceStatus { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> CampaignStatus { get; set; }
        public string CampaignNo { get; set; }
        public string Name { get; set; }
        public string CampaignNoName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> ExpectedImediateSale { get; set; }
        public Nullable<decimal> ExpectedFollowupSale { get; set; }
        public string OprettetAf { get; set; }
        public Nullable<System.DateTime> OprettetDen { get; set; }
        public string OprettetIP { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public string ParentName { get; set; }
        public string AgentName { get; set; }
        public Nullable<bool> RescueInfoEdit { get; set; }
        public string RescueInfoEditText { get; set; }
        public string RescueInfoEditText1 { get; set; }
        public Nullable<bool> RescueInfoEditUdvidet { get; set; }
        public string RescueInfoEditUdvidetText { get; set; }
        public string RescueInfoEditUdvidetText1 { get; set; }
    }
}