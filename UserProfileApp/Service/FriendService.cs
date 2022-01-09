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

        public Friend GetFriendById(int FriendId)
        {
            Friend FriendModel;
            using (var DB = new UserDBEntities())
            {
                FriendModel = DB.Friends.Where(av => av.Id == FriendId).FirstOrDefault();
            }
            return FriendModel;
        }

        public void ReSaveFriend(FriendModel Friends)
        {
            Friend FriendModel;
            var DB = new UserDBEntities();
            FriendModel = DB.Friends.Where(av => av.Id == Friends.Id).FirstOrDefault();
            FriendModel.FriendName = Friends.FriendName;
            FriendModel.Place = Friends.Place;

            DB.SaveChanges();
        }

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

        public bool DeleteFriend(int FriendId)
        {
            var DB = new UserDBEntities();
            var FriendModel = DB.Friends.Where(av => av.Id == FriendId).FirstOrDefault();
            FriendModel.IsActive = false;
            DB.SaveChanges();
            return  true;
        }
    }
}