using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserProfileApp.Models
{
    public class RegistrationModel
    {
        /// <summary>
        ///     Get or Set user Id.
        /// </summary>
        public  int UserId { get; set; }

        /// <summary>
        ///     Get or Set Email Id.
        /// </summary>
        public  string EmailId { get; set; }

        /// <summary>
        ///     Get or Set user name.
        /// </summary>
        public  string UserName { get; set; }

        /// <summary>
        ///     Get or Set City name.
        /// </summary>
        public  string City { get; set; }

        /// <summary>
        ///     Get or set Date of birth.
        /// </summary>
        public  string DOB { get; set; }
    }
}