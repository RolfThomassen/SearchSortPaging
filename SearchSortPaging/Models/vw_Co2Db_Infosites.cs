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
    
    public partial class vw_Co2Db_Infosites
    {
        public int ID { get; set; }
        public Nullable<bool> Aktiv { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> TemplateID { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<int> SplashPageID { get; set; }
        public Nullable<int> LoginPageID { get; set; }
        public Nullable<int> FrontPageID { get; set; }
        public string RettetAF { get; set; }
        public Nullable<System.DateTime> RettetDen { get; set; }
        public string RettetIP { get; set; }
    }
}
