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
    
    public partial class Co2Db_KundeGrp_Pris_SelectByKundeGrpVareNr_Result
    {
        public int ID { get; set; }
        public Nullable<int> status { get; set; }
        public int KundeGrpID { get; set; }
        public string KundeGrpNavn { get; set; }
        public int VareID { get; set; }
        public Nullable<double> SalgsPris { get; set; }
        public Nullable<double> Rabat { get; set; }
        public Nullable<double> KundePris { get; set; }
        public Nullable<double> FragtGebyr { get; set; }
        public Nullable<double> ProvisionRate { get; set; }
        public Nullable<System.DateTime> Dato { get; set; }
        public string VareNr { get; set; }
        public string Navn { get; set; }
        public Nullable<int> VareGrpID { get; set; }
        public string VareGrpNr { get; set; }
        public Nullable<double> Provision { get; set; }
    }
}
