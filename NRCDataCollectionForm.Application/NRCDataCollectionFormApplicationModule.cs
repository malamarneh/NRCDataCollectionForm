using System.Reflection;
using Abp.Modules;

namespace NRCDataCollectionForm
{
    [DependsOn(typeof(NRCDataCollectionFormCoreModule))]
    public class NRCDataCollectionFormApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
