//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABSignV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collection
    {
        public int CollectionID { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public Nullable<int> SignID { get; set; }
    
        public virtual Profile Profile { get; set; }
        public virtual Sign Sign { get; set; }
    }
}
