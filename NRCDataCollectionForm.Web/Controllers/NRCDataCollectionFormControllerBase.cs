using Abp.Web.Mvc.Controllers;

namespace NRCDataCollectionForm.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class NRCDataCollectionFormControllerBase : AbpController
    {
        protected NRCDataCollectionFormControllerBase()
        {
            LocalizationSourceName = NRCDataCollectionFormConsts.LocalizationSourceName;
        }
    }
}