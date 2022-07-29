using Abp.Web.Mvc.Controllers;
using NRCDataCollectionForm.Authentication;
using NRCDataCollectionForm.Models;
using NRCDataCollectionForm.AdminApp;
using NRCDataCollectionForm.Web.Models.Signin;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NRCDataCollectionForm.Web.Controllers
{
    public class AdminController : AbpController
    {
        private readonly IAdminAppService _adminAppService;
        private readonly IAuthenticationService _authenticationService;
        public AdminController(IAdminAppService adminAppService,
            IAuthenticationService authenticationService)
        {
            _adminAppService = adminAppService;
            _authenticationService = authenticationService;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(SigninViewModel model)
        {
            string userName = model.Username;
            string password = model.Password;


            Admin admin = _adminAppService.GetUserByAdminNameAndPassword(userName, password);

            if (admin != null)
            {
                _authenticationService.UserSignIn(admin);

                return RedirectToAction("Index", "Admin");

            }
            ViewBag.errMsg = "Invalid username and/or password";
            return View();

        }

        public ActionResult SignOut()
        {
            _authenticationService.UserSignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Signin", "Admin");
        }
    }
}