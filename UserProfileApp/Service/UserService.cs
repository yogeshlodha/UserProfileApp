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
        /// <summary>
        ///     Get user by userId
        /// </summary>
        /// <param name="UserId">user id</param>
        /// <returns>user profile model</returns>
        public UserProfile GetUserById(int UserId)
        {
            UserProfile userModel;
            using (var DB = new UserDBEntities())
            {
                userModel = DB.UserProfiles.Where(av => av.Id == UserId ).FirstOrDefault();
            }
            return userModel;
        }

        /// <summary>
        ///     Resave user profile record.
        /// </summary>
        /// <param name="users">user registration data.</param>
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

        /// <summary>
        ///     Get user list.
        /// </summary>
        /// <returns>user registration model list</returns>
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