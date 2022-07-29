using Abp.Web.Mvc.Views;

namespace NRCDataCollectionForm.Web.Views
{
    public abstract class NRCDataCollectionFormWebViewPageBase : NRCDataCollectionFormWebViewPageBase<dynamic>
    {

    }

    public abstract class NRCDataCollectionFormWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected NRCDataCollectionFormWebViewPageBase()
        {
            LocalizationSourceName = NRCDataCollectionFormConsts.LocalizationSourceName;
        }
    }
}