using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserProfileApp.Models
{
    public class RegistrationModel
    {
        public  int UserId { get; set; }
        public  string EmailId { get; set; }
        public  string UserName { get; set; }
        public  string City { get; set; }
        public  string DOB { get; set; }
    }
}