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
    
    public partial class vw_Co2Db_MedarbejderGruppe_Hospitalforsikring
    {
        public int ID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string Cvrnr { get; set; }
        public string Firmanavn { get; set; }
        public Nullable<bool> Aktiv { get; set; }
        public string Navn { get; set; }
        public string Brugernavn { get; set; }
        public string Kodeord { get; set; }
        public string Password { get; set; }
        public string IP { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<System.DateTime> Dato { get; set; }
        public Nullable<bool> Informationssite { get; set; }
        public Nullable<bool> Administrationssite { get; set; }
        public string RettetAF { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
        public string Noter { get; set; }
        public Nullable<int> Risikobonus { get; set; }
        public string LeverandorAftaleNr { get; set; }
        public Nullable<int> TimetalsbegraensningTimer { get; set; }
        public Nullable<int> Timetalsbegraensning { get; set; }
        public string OmfattedeMedarbejdereAndet { get; set; }
        public Nullable<int> OmfattedeMedarbejdere { get; set; }
        public Nullable<int> IndmeldelsestidspunktSenestEfter { get; set; }
        public Nullable<int> IndmeldelsestidspunktEfter { get; set; }
        public Nullable<int> IndmeldelseTidspunkt { get; set; }
        public Nullable<bool> ForsikringsdaekningStraks { get; set; }
        public Nullable<int> Forsikringsdaekning { get; set; }
        public Nullable<int> PraemieGruppe { get; set; }
        public Nullable<int> PraemieForhold { get; set; }
        public Nullable<int> HovedForfald { get; set; }
        public Nullable<int> Forfaldsmaade { get; set; }
        public Nullable<System.DateTime> Etableringsdato { get; set; }
        public Nullable<int> LeverandorID { get; set; }
        public Nullable<int> MedarbejderGruppeID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> HospitalsforsikringID { get; set; }
        public string htRettetAf { get; set; }
        public Nullable<System.DateTime> htRettetDen { get; set; }
        public string htRettetIP { get; set; }
        public Nullable<bool> htInformationssite { get; set; }
        public Nullable<bool> htAdministrationssite { get; set; }
    }
}
