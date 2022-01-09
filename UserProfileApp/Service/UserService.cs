using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserProfileApp.Models;
using UserProfileApp.Models.DB;

namespace UserProfileApp.Service
{
    public class UserService
    {
        public UserProfile GetUserById(int UserId)
        {
            UserProfile userModel;
            using (var DB = new UserDBEntities())
            {
                userModel = DB.UserProfiles.Where(av => av.Id == UserId ).FirstOrDefault();
            }
            return userModel;
        }

        public void ReSaveUser(RegistrationModel users)
        {
            UserProfile userModel;
            var DB = new UserDBEntities();
                userModel = DB.UserProfiles.Where(av => av.Id == users.UserId).FirstOrDefault();
                userModel.City = users.City;
                userModel.DOB = Convert.ToDateTime( users.DOB);
                userModel.EmailId = users.EmailId;
                userModel.UserName = users.UserName;
            
             DB.SaveChanges();
             
        }

        public List<RegistrationModel> GetUsersList()
        {
            List<RegistrationModel> userModel;
            using (var DB = new UserDBEntities())
            {
                userModel = DB.UserProfiles.Where(av => av.IsDeleted == false).Select(av=>new RegistrationModel { 
                  City = av.City,
                   DOB = av.DOB.HasValue? av.DOB.ToString():"",
                    EmailId = av.EmailId,
                     UserName = av.UserName,
                     UserId = av.Id 
                }).ToList();
            }
            return userModel;
        }
    }
}