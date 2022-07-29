using Abp.Application.Services;
using NRCDataCollectionForm.Models;
using System.Collections.Generic;

namespace NRCDataCollectionForm.Authentication
{
    public interface IAuthenticationService : IApplicationService
    {
        void UserSignIn(Admin admin);
        void UserSignOut();
    }
}
