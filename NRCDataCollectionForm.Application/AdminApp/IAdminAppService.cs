using Abp.Application.Services;
using NRCDataCollectionForm.Models;
using System.Collections.Generic;

namespace NRCDataCollectionForm.AdminApp
{
    public interface IAdminAppService : IApplicationService
    {
        Admin GetUserByAdminNameAndPassword(string userName, string password);
    }
}
