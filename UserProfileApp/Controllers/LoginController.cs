using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserProfileApp.Models;
using UserProfileApp.Service;

namespace UserProfileApp.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        ///     Get user login view.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View("_Login");
        }

        /// <summary>
        ///     Validate user crediential.
        /// </summary>
        /// <param name="emailId">Email Id</param>
        /// <param name="password">Password</param>
        /// <returns>Redirect to view as per condition.</returns>
        [HttpPost]
        public ActionResult Index(string emailId, string password   )
        {
            LoginModel model = new LoginModel(); 

            if(string.IsNullOrWhiteSpace(emailId) || string.IsNullOrWhiteSpace(password))
            {
                return View("_Login", new { errorMsg = "Invalid credential." });
            }

            LoginService loginService = new LoginService();
            model = new LoginModel { 
                emailId = emailId, 
                password = password 
            };
            if(loginService.checkLogin(model))
            {
                return View("Index", new { SuccessMsg = "Successfully login." });
            }
            else
            {
                return View("_Login", new { errorMsg = "Login Failed." });
            }
        }
    }
}