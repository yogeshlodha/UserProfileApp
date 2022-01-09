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
        [HttpGet]
        public  JsonResult GetUsers()
        {
            UserService userSer = new UserService();
            var userModel =  userSer.GetUsersList();

            return Json(userModel);
        }

        // GET: User
        public ActionResult UserList()
        {
            UserService userSer = new UserService();
            var userModel = userSer.GetUsersList();
            return View(userModel);
        }

        // GET: User
        public ActionResult UserEdit(int Id)
        {
            UserService userSer = new UserService();
            
            var userModel = userSer.GetUserById(Id);
            
            return View(userModel);
        }

        // POST: User
        [HttpPost]
        public ActionResult UserEdit(RegistrationModel model)
        {
            UserService userSer = new UserService();

             userSer.ReSaveUser(model);

            return RedirectToAction("UserList");
        }

        // GET: User
        public ActionResult UserDetails(int Id)
        {
            UserService userSer = new UserService();
            var userModel = userSer.GetUserById(Id);
            return View(userModel);
        }
    }
}