//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Run4RestServices.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Error
    {
        public int id { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorCategory { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
    }
}
