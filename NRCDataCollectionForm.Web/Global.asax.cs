using System;
using System.Security.Claims;
using System.Web.Helpers;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;

namespace NRCDataCollectionForm.Web
{
    public class MvcApplication : AbpWebApplication<NRCDataCollectionFormWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
#if DEBUG
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
#else
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.Production.config"))
            );
#endif
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimsIdentity.DefaultNameClaimType;
            base.Application_Start(sender, e);
        }
    }
}
