using Abp.Application.Services;
using NRCDataCollectionForm.Models;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;

namespace NRCDataCollectionForm.Authentication
{
    public class AuthenticationService : ApplicationService, IAuthenticationService
    {
        private const string AuthenticationType = "ApplicationCookie";
        public AuthenticationService()
        {
        }

        public void UserSignIn(Admin admin)
        {
            HttpContextBase httpContext = new HttpContextWrapper(HttpContext.Current);

            IList<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Sid, admin.Id.ToString()),
                new Claim(ClaimTypes.Name, admin.userName),
                new Claim(ClaimTypes.GivenName, admin.Name),
            };

            //foreach (string roleName in user.roleNames)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, roleName));
            //}

            ClaimsIdentity identity = new ClaimsIdentity(claims, AuthenticationType);

            IOwinContext context = httpContext.Request.GetOwinContext();
            IAuthenticationManager authenticationManager = context.Authentication;

            if (string.IsNullOrEmpty(AbpSession.UserId.ToString()))
            {
                AbpSession.Use(null, admin.Id); //set abp user for audit Modifier and Creator user id
            }

            authenticationManager.SignIn(identity);
        }

        public void UserSignOut()
        {
            HttpContextBase httpContext = new HttpContextWrapper(HttpContext.Current);
            IOwinContext context = httpContext.Request.GetOwinContext();
            IAuthenticationManager authenticationManager = context.Authentication;

            authenticationManager.SignOut(AuthenticationType);
        }
    }
}
