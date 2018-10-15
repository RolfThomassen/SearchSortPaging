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
    
    public partial class vw_Co2Db_Pensionsopsparing
    {
        public int ID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> MedarbejderGruppeID { get; set; }
        public Nullable<int> LeverandorID { get; set; }
        public Nullable<System.DateTime> Etableringsdato { get; set; }
        public Nullable<int> Forfald { get; set; }
        public Nullable<int> Indmeldelsestidspunkt { get; set; }
        public Nullable<int> IndmeldelsestidspunktAnsat { get; set; }
        public Nullable<int> IndmeldelsestidspunktAnciennitet { get; set; }
        public Nullable<int> IndmeldelsestidspunktFyldte { get; set; }
        public Nullable<int> Tidligst { get; set; }
        public Nullable<int> TidligstFyldte { get; set; }
        public Nullable<int> Senest { get; set; }
        public Nullable<int> Senest2FrivilligOver { get; set; }
        public Nullable<int> Senest3IkkeNyansatteOver { get; set; }
        public Nullable<int> Indmeldelseskriterier { get; set; }
        public Nullable<bool> Indmeldelseskriterier2frivillig { get; set; }
        public Nullable<int> Undtagelser { get; set; }
        public string Undtagelser3Fritekst { get; set; }
        public Nullable<bool> Invalidepension { get; set; }
        public Nullable<int> InvalidepensionType { get; set; }
        public Nullable<int> BasisInvalidepensioniPctAfGage { get; set; }
        public Nullable<int> BasisInvalidepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> BasisInvalidepensionDaekning { get; set; }
        public Nullable<int> FrivilligInvalidepensioniPctAfGage { get; set; }
        public Nullable<int> FrivilligInvalidepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> FrivilligInvalidepensionDaekning { get; set; }
        public Nullable<int> FrivilligInvalidepensionDaekning2PctAfGage { get; set; }
        public Nullable<decimal> BasisInvalidepensioniKr { get; set; }
        public Nullable<int> BasisInvalidepensioniKrUdlob { get; set; }
        public Nullable<decimal> FrivilligInvalidepensioniKr { get; set; }
        public Nullable<int> FrivilligInvalidepensioniKrUdlob { get; set; }
        public Nullable<decimal> InvalidepensionMindstKr { get; set; }
        public Nullable<bool> Invalidesum { get; set; }
        public Nullable<int> InvalidesumType { get; set; }
        public Nullable<int> BasisInvalidesumPctAfGage { get; set; }
        public Nullable<int> BasisInvalidesumUdlob { get; set; }
        public Nullable<int> BasisInvalidesumPctDaekning { get; set; }
        public Nullable<int> FrivilligInvalidesumPctAfGage { get; set; }
        public Nullable<int> FrivilligInvalidesumPctUdlob { get; set; }
        public Nullable<int> FrivilligInvalidesumPctDaekning { get; set; }
        public Nullable<int> FrivilligInvalidesumPctSolidariskDaekning { get; set; }
        public Nullable<int> BasisInvalidesumSkattekode { get; set; }
        public Nullable<int> FrivilligInvalidesumSkattekode { get; set; }
        public Nullable<decimal> BasisInvalidesumKr { get; set; }
        public Nullable<int> BasisInvalidesumKrUdlob { get; set; }
        public Nullable<int> BasisInvalidesumKrDaekning { get; set; }
        public Nullable<decimal> FrivilligInvalidesumKr { get; set; }
        public Nullable<int> FrivilligInvalidesumKrUdlob { get; set; }
        public Nullable<int> FrivilligInvalidesumKrDaekning { get; set; }
        public Nullable<decimal> FrivilligInvalidesumKrGruppedaekningKr { get; set; }
        public Nullable<decimal> InvalidesumMinimum { get; set; }
        public Nullable<bool> KritiskSygdom { get; set; }
        public Nullable<bool> KritiskSygdomType { get; set; }
        public Nullable<int> BasisKritiskSygdomPctAfGage { get; set; }
        public Nullable<int> BasisKritiskSygdomUdlob { get; set; }
        public Nullable<int> BasisKritiskSygdomPctDaekning { get; set; }
        public Nullable<int> FrivilligKritiskSygdomPctAfGage { get; set; }
        public Nullable<int> FrivilligKritiskSygdomPctUdlob { get; set; }
        public Nullable<int> FrivilligKritiskSygdomPctDaekning { get; set; }
        public Nullable<int> FrivilligKritiskSygdomPctSolidariskDaekning { get; set; }
        public Nullable<decimal> BasisKritiskSygdomKr { get; set; }
        public Nullable<int> BasisKritiskSygdomKrUdlob { get; set; }
        public Nullable<int> BasisKritiskSygdomKrDaekning { get; set; }
        public Nullable<decimal> FrivilligKritiskSygdomKr { get; set; }
        public Nullable<int> FrivilligKritiskSygdomKrUdlob { get; set; }
        public Nullable<int> FrivilligKritiskSygdomKrDaekning { get; set; }
        public Nullable<decimal> FrivilligKritiskSygdomKrGruppedaekningKr { get; set; }
        public Nullable<decimal> BasisKritiskSygdomMinimum { get; set; }
        public Nullable<bool> SygdomBornepension { get; set; }
        public Nullable<int> SygdomBornepensionType { get; set; }
        public Nullable<int> BasisSygdomBornepensioniPctAfGage { get; set; }
        public Nullable<int> BasisSygdomBornepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> BasisSygdomBornepensionDaekning { get; set; }
        public Nullable<int> FrivilligSygdomBornepensioniPctAfGage { get; set; }
        public Nullable<int> FrivilligSygdomBornepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> FrivilligSygdomBornepensionDaekning { get; set; }
        public Nullable<int> FrivilligSygdomBornepensionDaekning2PctSolidariskDaekning { get; set; }
        public Nullable<decimal> BasisSygdomBornepensioniKr { get; set; }
        public Nullable<int> BasisSygdomBornepensioniKrUdlob { get; set; }
        public Nullable<decimal> FrivilligSygdomBornepensioniKr { get; set; }
        public Nullable<int> FrivilligSygdomBornepensioniKrUdlob { get; set; }
        public Nullable<decimal> BasisSygdomBornepensionMindstKr { get; set; }
        public Nullable<bool> Dodfaldssum { get; set; }
        public Nullable<int> DodfaldssumType { get; set; }
        public Nullable<int> BasisDodfaldssumPctAfGage { get; set; }
        public Nullable<int> BasisDodfaldssumUdlob { get; set; }
        public Nullable<int> BasisDodfaldssumPctDaekning { get; set; }
        public Nullable<int> FrivilligDodfaldssumPctAfGage { get; set; }
        public Nullable<int> FrivilligDodfaldssumPctUdlob { get; set; }
        public Nullable<int> FrivilligDodfaldssumPctDaekning { get; set; }
        public Nullable<int> FrivilligDodfaldssumPctSolidariskDaekning { get; set; }
        public Nullable<int> BasisDodfaldssumSkattekode { get; set; }
        public Nullable<int> FrivilligDodfaldssumSkattekode { get; set; }
        public Nullable<decimal> BasisDodfaldssumKr { get; set; }
        public Nullable<int> BasisDodfaldssumKrUdlob { get; set; }
        public Nullable<int> BasisDodfaldssumKrDaekning { get; set; }
        public Nullable<decimal> FrivilligDodfaldssumKr { get; set; }
        public Nullable<int> FrivilligDodfaldssumKrUdlob { get; set; }
        public Nullable<int> FrivilligDodfaldssumKrDaekning { get; set; }
        public Nullable<decimal> FrivilligDodfaldssumKrGruppedaekningKr { get; set; }
        public Nullable<decimal> BasisDodfaldssumMinimum { get; set; }
        public Nullable<bool> Reservesikring { get; set; }
        public Nullable<int> ReservesikringType { get; set; }
        public Nullable<int> ReservesikringJa { get; set; }
        public Nullable<bool> DodBornepension { get; set; }
        public Nullable<int> BasisDodBornepension { get; set; }
        public Nullable<int> BasisDodBornepensioniPctAfGage { get; set; }
        public Nullable<int> BasisDodBornepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> BasisDodBornepensionDaekning { get; set; }
        public Nullable<int> FrivilligDodBornepensioniPctAfGage { get; set; }
        public Nullable<int> FrivilligDodBornepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> FrivilligDodBornepensionDaekning { get; set; }
        public Nullable<int> FrivilligDodBornepensionDaekning2SolidariskPctAfGage { get; set; }
        public Nullable<decimal> BasisDodBornepensioniKr { get; set; }
        public Nullable<int> BasisDodBornepensioniKrUdlob { get; set; }
        public Nullable<decimal> FrivilligDodBornepensioniKr { get; set; }
        public Nullable<int> FrivilligDodBornepensioniKrUdlob { get; set; }
        public Nullable<decimal> BasisDodBornepensionMindstKr { get; set; }
        public Nullable<bool> AEgtefaellepension { get; set; }
        public Nullable<int> BasisDodAEgtefaellepension { get; set; }
        public Nullable<int> BasisDodAEgtefaellepensioniPctAfGage { get; set; }
        public Nullable<int> BasisDodAEgtefaellepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> BasisDodAEgtefaellepensionDaekning { get; set; }
        public Nullable<int> FrivilligDodAEgtefaellepensioniPctAfGage { get; set; }
        public Nullable<int> FrivilligDodAEgtefaellepensioniPctAfGageUdlob { get; set; }
        public Nullable<int> FrivilligDodAEgtefaellepensionDaekning { get; set; }
        public Nullable<int> FrivilligDodAEgtefaellepensionDaekning2SolidariskPctAfGage { get; set; }
        public Nullable<decimal> BasisDodAEgtefaellepensioniKr { get; set; }
        public Nullable<int> BasisDodAEgtefaellepensioniKrUdlob { get; set; }
        public Nullable<decimal> FrivilligDodAEgtefaellepensioniKr { get; set; }
        public Nullable<int> FrivilligDodAEgtefaellepensioniKrUdlob { get; set; }
        public Nullable<int> ObligatoriskPensionsbidrag { get; set; }
        public Nullable<int> ObligatoriskPensionsbidragSkala { get; set; }
        public Nullable<int> ObligatoriskPensionsbidragIngenSkalaVirkBidragPct { get; set; }
        public Nullable<decimal> ObligatoriskPensionsbidragIngenSkalaVirkBidragKr { get; set; }
        public Nullable<int> ObligatoriskPensionsbidragIngenSkalaMedArbBidragPct { get; set; }
        public Nullable<decimal> ObligatoriskPensionsbidragIngenSkalaMedArbBidragKr { get; set; }
        public Nullable<System.DateTime> SkalaDato1 { get; set; }
        public Nullable<int> SkalaDatoVirksomhedsbidrag1 { get; set; }
        public Nullable<int> SkalaDatoMedarbejderbidrag1 { get; set; }
        public Nullable<System.DateTime> SkalaDato2 { get; set; }
        public Nullable<int> SkalaDatoVirksomhedsbidrag2 { get; set; }
        public Nullable<int> SkalaDatoMedarbejderbidrag2 { get; set; }
        public Nullable<System.DateTime> SkalaDato3 { get; set; }
        public Nullable<int> SkalaDatoVirksomhedsbidrag3 { get; set; }
        public Nullable<int> SkalaDatoMedarbejderbidrag3 { get; set; }
        public Nullable<System.DateTime> SkalaDato4 { get; set; }
        public Nullable<int> SkalaDatoVirksomhedsbidrag4 { get; set; }
        public Nullable<int> SkalaDatoMedarbejderbidrag4 { get; set; }
        public Nullable<System.DateTime> SkalaDato5 { get; set; }
        public Nullable<int> SkalaDatoVirksomhedsbidrag5 { get; set; }
        public Nullable<int> SkalaDatoMedarbejderbidrag5 { get; set; }
        public Nullable<int> SkalaAlder1 { get; set; }
        public Nullable<int> SkalaAlderVirksomhedsbidrag1 { get; set; }
        public Nullable<int> SkalaAlderMedarbejderbidrag1 { get; set; }
        public Nullable<int> SkalaAlder2 { get; set; }
        public Nullable<int> SkalaAlderVirksomhedsbidrag2 { get; set; }
        public Nullable<int> SkalaAlderMedarbejderbidrag2 { get; set; }
        public Nullable<int> SkalaAlder3 { get; set; }
        public Nullable<int> SkalaAlderVirksomhedsbidrag3 { get; set; }
        public Nullable<int> SkalaAlderMedarbejderbidrag3 { get; set; }
        public Nullable<int> SkalaAlder4 { get; set; }
        public Nullable<int> SkalaAlderVirksomhedsbidrag4 { get; set; }
        public Nullable<int> SkalaAlderMedarbejderbidrag4 { get; set; }
        public Nullable<int> SkalaAlder5 { get; set; }
        public Nullable<int> SkalaAlderVirksomhedsbidrag5 { get; set; }
        public Nullable<int> SkalaAlderMedarbejderbidrag5 { get; set; }
        public Nullable<int> SkalaAnciennitet1 { get; set; }
        public Nullable<int> SkalaAnciennitetVirksomhedsbidrag1 { get; set; }
        public Nullable<int> SkalaAnciennitetMedarbejderbidrag1 { get; set; }
        public Nullable<int> SkalaAnciennitet2 { get; set; }
        public Nullable<int> SkalaAnciennitetVirksomhedsbidrag2 { get; set; }
        public Nullable<int> SkalaAnciennitetMedarbejderbidrag2 { get; set; }
        public Nullable<int> SkalaAnciennitet3 { get; set; }
        public Nullable<int> SkalaAnciennitetVirksomhedsbidrag3 { get; set; }
        public Nullable<int> SkalaAnciennitetMedarbejderbidrag3 { get; set; }
        public Nullable<int> SkalaAnciennitet4 { get; set; }
        public Nullable<int> SkalaAnciennitetVirksomhedsbidrag4 { get; set; }
        public Nullable<int> SkalaAnciennitetMedarbejderbidrag4 { get; set; }
        public Nullable<int> SkalaAnciennitet5 { get; set; }
        public Nullable<int> SkalaAnciennitetVirksomhedsbidrag5 { get; set; }
        public Nullable<int> SkalaAnciennitetMedarbejderbidrag5 { get; set; }
        public Nullable<int> Overenskomstforhold { get; set; }
        public Nullable<int> OverenskomstforholdOverenskomster { get; set; }
        public Nullable<int> Genkob { get; set; }
        public Nullable<bool> OpsparingstyperKapitalpension { get; set; }
        public Nullable<int> OpsparingstyperKapitalpensionUdlob { get; set; }
        public Nullable<bool> OpsparingstyperRatepension { get; set; }
        public Nullable<int> OpsparingstyperRatepensionUdlob { get; set; }
        public Nullable<bool> OpsparingstyperLivrentepension { get; set; }
        public Nullable<int> OpsparingstyperLivrentepensionUdlob { get; set; }
        public Nullable<int> OpsparingstyperKrav { get; set; }
        public Nullable<int> OpsparingstyperKravRatePct { get; set; }
        public Nullable<int> OpsparingstyperKravLivsvarigPct { get; set; }
        public Nullable<int> Opsparingsform { get; set; }
        public Nullable<int> Opsparingsform2LinkopsparingPct { get; set; }
        public Nullable<int> Opsparingsform2AMPmarkedsopsparingPct { get; set; }
        public Nullable<int> Helbredsoplysninger { get; set; }
        public Nullable<int> HelbredsoplysningerNytegning { get; set; }
        public Nullable<int> HelbredsoplysningerNytegning3PersonligeHelbredsoplysningerType { get; set; }
        public Nullable<int> HelbredsoplysningerAttestgraense { get; set; }
        public Nullable<int> ServicekonceptIndmeldelse { get; set; }
        public Nullable<int> Policeudstedelse { get; set; }
        public Nullable<int> Omkostninger { get; set; }
        public Nullable<bool> SitesInformationssite { get; set; }
        public Nullable<bool> SitesAdministrationssite { get; set; }
        public Nullable<int> SitesKontaktpersoner { get; set; }
        public string Noter { get; set; }
        public string RettetAf { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
    }
}
