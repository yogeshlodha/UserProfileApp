using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserProfileApp.Models;
using UserProfileApp.Models.DB;
using UserProfileApp.Service;

namespace UserProfileApp.Controllers
{
    public class FriendController : Controller
    {
        /// <summary>
        /// Add a new friend records.
        /// </summary>
        /// <returns>render view</returns>
        [HttpGet]
        public ActionResult FriendAdd()
        {
            Friend model = new Friend();
                return View(model);
        }

        /// <summary>
        /// Add a new friend records.
        /// </summary>
        /// <returns>render view</returns>
        [HttpPost]
        public ActionResult FriendAdd(FriendModel model)
        {
            if (ModelState.IsValid)
            {
                FriendService friendService = new FriendService();
                friendService.AddFriend(model);

                return RedirectToAction("Index","Friend");
            }
            return View();
        }
        /// <summary>
        /// Render friend records.
        /// </summary>
        /// <returns>Friend records model</returns>
        public ActionResult index()
        {
            FriendService friendService = new FriendService();
            var frndModel = friendService.GetFriendsList();
            return View(frndModel);
        }

        /// <summary>
        /// Edit friend record
        /// </summary>
        /// <param name="Id">Friend Id</param>
        /// <returns>Friend records model</returns>
        public ActionResult FriendEdit(int Id)
        {
            FriendService friendService = new FriendService();
            var frndModel = friendService.GetFriendById(Id);
            return View(frndModel);
        }

        /// <summary>
        /// Edit friend model 
        /// </summary>
        /// <param name="model">modified friends record</param>
        /// <returns>redirect to index page.</returns>
        [HttpPost]
        public ActionResult FriendEdit(FriendModel model)
        {
            FriendService friendService = new FriendService();
            friendService.ReSaveFriend(model);
            return RedirectToAction("index");
        }

        /// <summary>
        /// Mark deleted records.
        /// </summary>
        /// <param name="Id">Friend Id</param>
        /// <returns>status of deleted records</returns>
        public ActionResult DeleteRecords(int Id)
        {
            FriendService userSer = new FriendService();
            userSer.DeleteFriend(Id);
            return RedirectToAction("Index","Friend");
        }
    }
}