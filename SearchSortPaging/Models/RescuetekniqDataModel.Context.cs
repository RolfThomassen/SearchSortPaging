﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vicjos1_rescuetekniq_Entities : DbContext
    {
        public vicjos1_rescuetekniq_Entities()
            : base("name=vicjos1_rescuetekniq_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vw_Co2Db_AED> vw_Co2Db_AED { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Battery> vw_Co2Db_AED_Battery { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Battery_Company> vw_Co2Db_AED_Battery_Company { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Battery_Electrod_List> vw_Co2Db_AED_Battery_Electrod_List { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Battery_Electrod_List_BilagStatus> vw_Co2Db_AED_Battery_Electrod_List_BilagStatus { get; set; }
        public virtual DbSet<vw_Co2Db_AED_BatteryAktiv> vw_Co2Db_AED_BatteryAktiv { get; set; }
        public virtual DbSet<vw_Co2Db_AED_BatteryUdlob> vw_Co2Db_AED_BatteryUdlob { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Electrod> vw_Co2Db_AED_Electrod { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Electrod_Company> vw_Co2Db_AED_Electrod_Company { get; set; }
        public virtual DbSet<vw_Co2Db_AED_ElectrodAktiv> vw_Co2Db_AED_ElectrodAktiv { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Infolist> vw_Co2Db_AED_Infolist { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Redning> vw_Co2Db_AED_Redning { get; set; }
        public virtual DbSet<vw_Co2Db_AED_RedningAktiv> vw_Co2Db_AED_RedningAktiv { get; set; }
        public virtual DbSet<vw_Co2Db_AED_RedningUdlob> vw_Co2Db_AED_RedningUdlob { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Service> vw_Co2Db_AED_Service { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Service_Aktiv> vw_Co2Db_AED_Service_Aktiv { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Service_Company> vw_Co2Db_AED_Service_Company { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Service_Udlob> vw_Co2Db_AED_Service_Udlob { get; set; }
        public virtual DbSet<vw_Co2Db_AED_Trainer> vw_Co2Db_AED_Trainer { get; set; }
        public virtual DbSet<vw_Co2Db_Agent_Virksomhed> vw_Co2Db_Agent_Virksomhed { get; set; }
        public virtual DbSet<vw_Co2Db_Agents> vw_Co2Db_Agents { get; set; }
        public virtual DbSet<vw_Co2Db_Aiva> vw_Co2Db_Aiva { get; set; }
        public virtual DbSet<vw_Co2Db_Campaign> vw_Co2Db_Campaign { get; set; }
        public virtual DbSet<vw_Co2Db_Campaign_Company> vw_Co2Db_Campaign_Company { get; set; }
        public virtual DbSet<vw_Co2Db_Company_KundeGrp_VarePris> vw_Co2Db_Company_KundeGrp_VarePris { get; set; }
        public virtual DbSet<vw_Co2Db_Currency> vw_Co2Db_Currency { get; set; }
        public virtual DbSet<vw_Co2Db_Dokumenter> vw_Co2Db_Dokumenter { get; set; }
        public virtual DbSet<vw_Co2Db_Dokumenter_Firmadokumenter> vw_Co2Db_Dokumenter_Firmadokumenter { get; set; }
        public virtual DbSet<vw_Co2Db_Dokumenter_Forsikringer> vw_Co2Db_Dokumenter_Forsikringer { get; set; }
        public virtual DbSet<vw_Co2Db_DokumenterBlob> vw_Co2Db_DokumenterBlob { get; set; }
        public virtual DbSet<vw_Co2Db_DokumenterClob> vw_Co2Db_DokumenterClob { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash> vw_Co2Db_EyeWash { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_Bottle> vw_Co2Db_EyeWash_Bottle { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_Bottle_Company> vw_Co2Db_EyeWash_Bottle_Company { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_BottleAktiv> vw_Co2Db_EyeWash_BottleAktiv { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_BottleUdlob> vw_Co2Db_EyeWash_BottleUdlob { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_Service> vw_Co2Db_EyeWash_Service { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_Service_Aktiv> vw_Co2Db_EyeWash_Service_Aktiv { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_Service_Company> vw_Co2Db_EyeWash_Service_Company { get; set; }
        public virtual DbSet<vw_Co2Db_EyeWash_Service_Udlob> vw_Co2Db_EyeWash_Service_Udlob { get; set; }
        public virtual DbSet<vw_Co2Db_FirstAidBag> vw_Co2Db_FirstAidBag { get; set; }
        public virtual DbSet<vw_Co2Db_FirstAidBag_Infolist> vw_Co2Db_FirstAidBag_Infolist { get; set; }
        public virtual DbSet<vw_Co2Db_FirstAidBag_Service> vw_Co2Db_FirstAidBag_Service { get; set; }
        public virtual DbSet<vw_Co2Db_FirstAidBag_Service_Aktiv> vw_Co2Db_FirstAidBag_Service_Aktiv { get; set; }
        public virtual DbSet<vw_Co2Db_FirstAidBag_Service_Company> vw_Co2Db_FirstAidBag_Service_Company { get; set; }
        public virtual DbSet<vw_Co2Db_FirstAidBag_Service_Udlob> vw_Co2Db_FirstAidBag_Service_Udlob { get; set; }
        public virtual DbSet<vw_Co2Db_Hospitalforsikring> vw_Co2Db_Hospitalforsikring { get; set; }
        public virtual DbSet<vw_Co2Db_HospitalsForsikring> vw_Co2Db_HospitalsForsikring { get; set; }
        public virtual DbSet<vw_Co2Db_HtmlPageContent> vw_Co2Db_HtmlPageContent { get; set; }
        public virtual DbSet<vw_Co2Db_Incasso> vw_Co2Db_Incasso { get; set; }
        public virtual DbSet<vw_Co2Db_InfositeContent> vw_Co2Db_InfositeContent { get; set; }
        public virtual DbSet<vw_Co2Db_InfositeContents> vw_Co2Db_InfositeContents { get; set; }
        public virtual DbSet<vw_Co2Db_InfositePage> vw_Co2Db_InfositePage { get; set; }
        public virtual DbSet<vw_Co2Db_InfositePages> vw_Co2Db_InfositePages { get; set; }
        public virtual DbSet<vw_Co2Db_Infosites> vw_Co2Db_Infosites { get; set; }
        public virtual DbSet<vw_Co2Db_Invoice_Agent_Provision_list> vw_Co2Db_Invoice_Agent_Provision_list { get; set; }
        public virtual DbSet<vw_Co2Db_Invoice_Head> vw_Co2Db_Invoice_Head { get; set; }
        public virtual DbSet<vw_Co2Db_Invoice_Head_All> vw_Co2Db_Invoice_Head_All { get; set; }
        public virtual DbSet<vw_Co2Db_Invoice_Line> vw_Co2Db_Invoice_Line { get; set; }
        public virtual DbSet<vw_Co2Db_Invoice_Stats> vw_Co2Db_Invoice_Stats { get; set; }
        public virtual DbSet<vw_Co2Db_Invoice_TotalInvoicePrice> vw_Co2Db_Invoice_TotalInvoicePrice { get; set; }
        public virtual DbSet<vw_Co2Db_Korrespondance> vw_Co2Db_Korrespondance { get; set; }
        public virtual DbSet<vw_Co2Db_Korrespondance_all> vw_Co2Db_Korrespondance_all { get; set; }
        public virtual DbSet<vw_Co2Db_KorrespondanceBlob> vw_Co2Db_KorrespondanceBlob { get; set; }
        public virtual DbSet<vw_Co2Db_KundeGrp> vw_Co2Db_KundeGrp { get; set; }
        public virtual DbSet<vw_Co2Db_KundeGrp_Pris> vw_Co2Db_KundeGrp_Pris { get; set; }
        public virtual DbSet<vw_Co2Db_KursusDag> vw_Co2Db_KursusDag { get; set; }
        public virtual DbSet<vw_Co2Db_KursusDagListeKursister> vw_Co2Db_KursusDagListeKursister { get; set; }
        public virtual DbSet<vw_Co2Db_KursusDeltager> vw_Co2Db_KursusDeltager { get; set; }
        public virtual DbSet<vw_Co2Db_KursusListe> vw_Co2Db_KursusListe { get; set; }
        public virtual DbSet<vw_Co2Db_KursusPolicy> vw_Co2Db_KursusPolicy { get; set; }
        public virtual DbSet<vw_Co2Db_Logline> vw_Co2Db_Logline { get; set; }
        public virtual DbSet<vw_Co2Db_Medarbejder> vw_Co2Db_Medarbejder { get; set; }
        public virtual DbSet<vw_Co2Db_Medarbejder_Forsikring> vw_Co2Db_Medarbejder_Forsikring { get; set; }
        public virtual DbSet<vw_Co2Db_MedarbejderGruppe_Hospitalforsikring> vw_Co2Db_MedarbejderGruppe_Hospitalforsikring { get; set; }
        public virtual DbSet<vw_Co2Db_MedarbejderGruppe_Medarbejder> vw_Co2Db_MedarbejderGruppe_Medarbejder { get; set; }
        public virtual DbSet<vw_Co2Db_MedarbejderGruppe_Pensionsopsparing> vw_Co2Db_MedarbejderGruppe_Pensionsopsparing { get; set; }
        public virtual DbSet<vw_Co2Db_MedarbejderGruppe_Virksomheder_list> vw_Co2Db_MedarbejderGruppe_Virksomheder_list { get; set; }
        public virtual DbSet<vw_Co2Db_MedarbejderGrupper> vw_Co2Db_MedarbejderGrupper { get; set; }
        public virtual DbSet<vw_Co2Db_News> vw_Co2Db_News { get; set; }
        public virtual DbSet<vw_Co2Db_NewsGrp> vw_Co2Db_NewsGrp { get; set; }
        public virtual DbSet<vw_Co2Db_NewsGrpList> vw_Co2Db_NewsGrpList { get; set; }
        public virtual DbSet<vw_Co2Db_Noter> vw_Co2Db_Noter { get; set; }
        public virtual DbSet<vw_Co2Db_PageAccess> vw_Co2Db_PageAccess { get; set; }
        public virtual DbSet<vw_Co2Db_Pax> vw_Co2Db_Pax { get; set; }
        public virtual DbSet<vw_Co2Db_Pensionsopsparing> vw_Co2Db_Pensionsopsparing { get; set; }
        public virtual DbSet<vw_Co2Db_Postnr> vw_Co2Db_Postnr { get; set; }
        public virtual DbSet<vw_Co2Db_PractiMan> vw_Co2Db_PractiMan { get; set; }
        public virtual DbSet<vw_Co2Db_PurchaseOrder> vw_Co2Db_PurchaseOrder { get; set; }
        public virtual DbSet<vw_Co2Db_PurchaseOrder_TotalOrderPrice> vw_Co2Db_PurchaseOrder_TotalOrderPrice { get; set; }
        public virtual DbSet<vw_Co2Db_PurchaseOrderItem> vw_Co2Db_PurchaseOrderItem { get; set; }
        public virtual DbSet<vw_Co2Db_Tilbud> vw_Co2Db_Tilbud { get; set; }
        public virtual DbSet<vw_Co2Db_Tilbud_TotalTilbudspris> vw_Co2Db_Tilbud_TotalTilbudspris { get; set; }
        public virtual DbSet<vw_Co2Db_TilbudHospital> vw_Co2Db_TilbudHospital { get; set; }
        public virtual DbSet<vw_Co2Db_Tilbudhospital_Virksomhed> vw_Co2Db_Tilbudhospital_Virksomhed { get; set; }
        public virtual DbSet<vw_Co2Db_TilbudsLinie> vw_Co2Db_TilbudsLinie { get; set; }
        public virtual DbSet<vw_Co2Db_UserRoleList> vw_Co2Db_UserRoleList { get; set; }
        public virtual DbSet<vw_Co2Db_Vare> vw_Co2Db_Vare { get; set; }
        public virtual DbSet<vw_Co2Db_VareGrp> vw_Co2Db_VareGrp { get; set; }
        public virtual DbSet<vw_Co2Db_VareGrpList> vw_Co2Db_VareGrpList { get; set; }
        public virtual DbSet<vw_Co2Db_VareList> vw_Co2Db_VareList { get; set; }
        public virtual DbSet<vw_Co2Db_Virksomheder> vw_Co2Db_Virksomheder { get; set; }
        public virtual DbSet<vw_Co2Db_Virksomheder_Service_Weber> vw_Co2Db_Virksomheder_Service_Weber { get; set; }
    }
}
