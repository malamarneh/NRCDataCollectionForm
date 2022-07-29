using System.Data.Entity.Migrations;

namespace NRCDataCollectionForm.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<NRCDataCollectionForm.EntityFramework.NRCDataCollectionFormDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NRCDataCollectionForm";
        }

        protected override void Seed(NRCDataCollectionForm.EntityFramework.NRCDataCollectionFormDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...

            context.Admins.AddOrUpdate(p => p.Name,
                   new Models.Admin { userName = "NRCAdmin", Name = "NRC Admin", Password = "NRCAdmin@123"});
        }
    }
}
