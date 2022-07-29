using Abp.Application.Services;
using NRCDataCollectionForm.Models;
using System.Collections.Generic;

namespace NRCDataCollectionForm.CollectionFormApp
{
    public interface ICollectionFormAppService: IApplicationService
    {
        List<CollectionForm> GetAll();
        void Create(CollectionForm collectionForm);
        CollectionForm GetById(int id);
    }
}
