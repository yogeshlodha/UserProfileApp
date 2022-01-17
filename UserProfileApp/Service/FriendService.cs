using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserProfileApp.Models;
using UserProfileApp.Models.DB;

namespace UserProfileApp.Service
{
    public class FriendService
    {
        /// <summary>
        ///     Add to friend 
        /// </summary>
        /// <param name="Friends">Friend model</param>
        public void AddFriend(FriendModel Friends)
        {
            Friend FriendModel = new Friend();
            var DB = new UserDBEntities();
            FriendModel.FriendName = Friends.FriendName;
            FriendModel.Place = Friends.Place;
            FriendModel.FriendId = Friends.FriendId; 
            FriendModel.IsActive = true;

            DB.Friends.Add(FriendModel);
            DB.SaveChanges();
        }

        /// <summary>
        ///     Get friend by friendId
        /// </summary>
        /// <param name="FriendId">Friend Id</param>
        /// <returns></returns>
        public Friend GetFriendById(int FriendId)
        {
            Friend FriendModel;
            using (var DB = new UserDBEntities())
            {
                FriendModel = DB.Friends.Where(av => av.Id == FriendId).FirstOrDefault();
            }
            return FriendModel;
        }

        /// <summary>
        ///     Resave friend record.
        /// </summary>
        /// <param name="Friends">friend model</param>
        public void ReSaveFriend(FriendModel Friends)
        {
            Friend FriendModel;
            var DB = new UserDBEntities();
            FriendModel = DB.Friends.Where(av => av.Id == Friends.Id).FirstOrDefault();
            FriendModel.FriendName = Friends.FriendName;
            FriendModel.Place = Friends.Place;

            DB.SaveChanges();
        }

        /// <summary>
        ///     Get friends list
        /// </summary>
        /// <returns>friend model</returns>
        public List<FriendModel> GetFriendsList()
        {
            List<FriendModel> FriendModel;
            using (var DB = new UserDBEntities())
            {
                FriendModel = DB.Friends.Where(av=>av.IsActive == true).Select(av => new FriendModel
                {
                    FriendName = av.FriendName,
                    FriendId = av.FriendId.ToString(),
                    Place = av.Place,
                    Id = av.Id
                }).ToList();
            }
            return FriendModel;
        }

        /// <summary>
        ///     delete friend record.
        /// </summary>
        /// <param name="FriendId">friend Id</param>
        /// <returns></returns>
        public bool DeleteFriend(int FriendId)
        {
            var DB = new UserDBEntities();
            var FriendModel = DB.Friends.Where(av => av.Id == FriendId).FirstOrDefault();
            FriendModel.IsActive = false;
            return  DB.SaveChanges() > 0 ? true:false;
        }
    }
}