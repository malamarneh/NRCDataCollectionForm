using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Application.Navigation;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.Threading;
using NRCDataCollectionForm.Web.Models.Layout;

namespace NRCDataCollectionForm.Web.Controllers
{
    public class LayoutController : NRCDataCollectionFormControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILanguageManager _languageManager;

        public LayoutController(
            IUserNavigationManager userNavigationManager, 
            ILocalizationManager localizationManager,
            ILanguageManager languageManager)
        {
            _userNavigationManager = userNavigationManager;
            _languageManager = languageManager;
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu(string activeMenu = "")
        {
            var model = new TopMenuViewModel
                        {
                            MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier())),
                            ActiveMenuItemName = activeMenu
                        };

            return PartialView("_TopMenu", model);
        }

        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
                        {
                            CurrentLanguage = _languageManager.CurrentLanguage,
                            Languages = _languageManager.GetLanguages()
                        };

            return PartialView("_LanguageSelection", model);
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            if (!System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                requestContext.HttpContext.Response.Clear();
                requestContext.HttpContext.Response.Redirect(Url.Action("Signin", "Admin"), false);
                requestContext.HttpContext.Response.End();
            }
            else
            {
                var identity = (ClaimsIdentity)User.Identity;

                List<Claim> claims = identity.Claims.ToList();

                foreach (var claim in claims)
                {
                    //if (claim.Type.Contains("/givenname"))
                    //    ViewBag.UserFullName = claim.Value;
                    if (string.IsNullOrEmpty(AbpSession.UserId.ToString()))
                    {
                        if (claim.Type.Contains("/sid"))
                            AbpSession.Use(null, Convert.ToInt64(claim.Value)); //set abp user for audit Modifier and Creator user id
                    }

                }

                //User user = _usersAppService.GetUserById(Convert.ToInt32(AbpSession.UserId.ToString()));
            }
        }
    }
}