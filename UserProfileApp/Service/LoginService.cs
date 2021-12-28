using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserProfileApp.Models;
using UserProfileApp.Models.DB;

namespace UserProfileApp.Service
{
    public class LoginService
    {
        public bool checkLogin(LoginModel model)
        {
            UserLogin userModel;
            using (var DB = new UserDBEntities())
            {
                 userModel = DB.UserLogins.Where(av => av.Emailid == model.emailId
                && av.Password == model.password).FirstOrDefault();
            }
                return userModel != null ? true : false;
        }
    }
}