using System.Reflection;
using Abp.Modules;

namespace NRCDataCollectionForm
{
    public class NRCDataCollectionFormCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = NRCDataCollectionFormConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
