using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Abp.UI;
using NRCDataCollectionForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NRCDataCollectionForm.CollectionFormApp
{
    public class CollectionFormAppService : ApplicationService, ICollectionFormAppService
    {
        private readonly IRepository<CollectionForm> _collectionFormRepository;

        public CollectionFormAppService(IAbpSession abpSession,
            IRepository<CollectionForm> collectionFormRepository)
        {
            LocalizationSourceName = NRCDataCollectionFormConsts.LocalizationSourceName;
            _collectionFormRepository = collectionFormRepository;
        }

        public List<CollectionForm> GetAll()
        {
            IEnumerable<CollectionForm> collectionForms = _collectionFormRepository.GetAll();//IEnumerable for performance
            List<CollectionForm> collectionFormsLst = collectionForms.ToList();


            return collectionFormsLst;
        }

        public void Create(CollectionForm collectionForm)
        {

            _collectionFormRepository.Insert(collectionForm);

        }

        public CollectionForm GetById(int id)
        {
            return _collectionFormRepository.Get(id);
        }


    }
}
