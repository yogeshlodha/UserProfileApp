using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserProfileApp.Models
{
    public class FriendModel
    {
        [Required(ErrorMessage = "Friend Id Empty Not Allowed.")]
        public string FriendId  {get;set;}

        [Required(ErrorMessage = "Friend Name Empty Not Allowed.")]
        public string FriendName  {get;set;}

        [MaxLength( 25 ,ErrorMessage = "Place max length 25 character.")]
        public string  Place  {get;set;}
        public   bool IsActive { get; set; }
        public int Id { get; set; }
    }
}