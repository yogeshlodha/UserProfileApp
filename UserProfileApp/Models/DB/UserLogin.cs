//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserProfileApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLogin
    {
        public int Id { get; set; }
        public Nullable<int> UserProfileId { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
