//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoeShopOnline.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Slide
    {
        public int Id { get; set; }
        public string UrlImage { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTimeOffset> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}