using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using NRCDataCollectionForm.EntityFramework;

namespace NRCDataCollectionForm
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(NRCDataCollectionFormCoreModule))]
    public class NRCDataCollectionFormDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<NRCDataCollectionFormDbContext>(null);
        }
    }
}
