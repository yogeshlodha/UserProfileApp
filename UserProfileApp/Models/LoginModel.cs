using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserProfileApp.Models
{
    public class LoginModel
    {
        /// <summary>
        ///     get or set Email Id.
        /// </summary>
        public string emailId { get; set; }

        /// <summary>
        ///     get or set password.
        /// </summary>
        public string password { get; set; }
    }
}