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
    
    public partial class tblFriend
    {
        public int Id { get; set; }
        public string FriendName { get; set; }
        public string Place { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}