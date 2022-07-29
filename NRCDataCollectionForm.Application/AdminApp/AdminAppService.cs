using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Abp.UI;
using NRCDataCollectionForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NRCDataCollectionForm.AdminApp
{
    public class AdminAppService : ApplicationService, IAdminAppService
    {
        private readonly IRepository<Admin> _adminRepository;

        public AdminAppService(IAbpSession abpSession,
            IRepository<Admin> adminRepository)
        {
            LocalizationSourceName = NRCDataCollectionFormConsts.LocalizationSourceName;
            _adminRepository = adminRepository;
        }

        public Admin GetUserByAdminNameAndPassword(string userName, string password)
        {
            Admin admin = _adminRepository.GetAll().Where(x => x.userName == userName && x.Password == password).FirstOrDefault();
            return admin;
        }


    }
}
