using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserProfileApp.Models;
using UserProfileApp.Service;

namespace UserProfileApp.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        ///     Get user list view.
        /// </summary>
        /// <returns>user list data.</returns>
        [HttpGet]
        public  JsonResult GetUsers()
        {
            UserService userSer = new UserService();
            var userModel =  userSer.GetUsersList();
            return Json(userModel);
        }

        /// <summary>
        ///     Get user records by User Id.
        /// </summary>
        /// <param name="Id">User Id</param>
        /// <returns>render user model</returns>
        public ActionResult UserEdit(int Id)
        {
            UserService userSer = new UserService();
            
            var userModel = userSer.GetUserById(Id);
            
            return View(userModel);
        }

        /// <summary>
        ///     Modified user records.
        /// </summary>
        /// <param name="model">registration model</param>
        /// <returns>redirect to user list view.</returns>
        [HttpPost]
        public ActionResult UserEdit(RegistrationModel model)
        {
            UserService userSer = new UserService();

             userSer.ReSaveUser(model);

            return RedirectToAction("UserList");
        }

        /// <summary>
        ///     Render user details records.
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns>User model</returns>
        public ActionResult UserDetails(int Id)
        {
            UserService userSer = new UserService();
            var userModel = userSer.GetUserById(Id);
            return View(userModel);
        }

        /// <summary>
        ///     Get user list view.
        /// </summary>
        /// <returns>render user data.</returns>
        public ActionResult UserList()
        {
            UserService userSer = new UserService();
            var userModel = userSer.GetUsersList();
            return View(userModel);
        }


    }
}