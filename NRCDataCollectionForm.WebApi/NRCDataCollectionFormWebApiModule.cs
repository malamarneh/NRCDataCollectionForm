using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace NRCDataCollectionForm
{
    [DependsOn(typeof(AbpWebApiModule), typeof(NRCDataCollectionFormApplicationModule))]
    public class NRCDataCollectionFormWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(NRCDataCollectionFormApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
