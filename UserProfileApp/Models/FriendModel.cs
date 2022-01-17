using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserProfileApp.Models
{
    public class FriendModel
    {
        /// <summary>
        ///     get or set friend Id.
        /// </summary>
        [Required(ErrorMessage = "Friend Id Empty Not Allowed.")]
        public string FriendId  {get;set;}

        /// <summary>
        ///     get or set friend name.
        /// </summary>
        [Required(ErrorMessage = "Friend Name Empty Not Allowed.")]
        public string FriendName  {get;set;}

        /// <summary>
        ///     get or set place record.
        /// </summary>
        [MaxLength( 25 ,ErrorMessage = "Place max length 25 character.")]
        public string  Place  {get;set;}

        /// <summary>
        ///     Get or Set record active status
        /// </summary>
        public   bool IsActive { get; set; }
        /// <summary>
        ///     Get or set records Id
        /// </summary>
        public int Id { get; set; }
    }
}