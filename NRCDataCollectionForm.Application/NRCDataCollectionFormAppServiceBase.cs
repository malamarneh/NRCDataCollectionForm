using Abp.Application.Services;

namespace NRCDataCollectionForm
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class NRCDataCollectionFormAppServiceBase : ApplicationService
    {
        protected NRCDataCollectionFormAppServiceBase()
        {
            LocalizationSourceName = NRCDataCollectionFormConsts.LocalizationSourceName;
        }
    }
}