using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using NRCDataCollectionForm.Models;

namespace NRCDataCollectionForm.EntityFramework
{
    public class NRCDataCollectionFormDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public virtual IDbSet<CollectionForm> CollectionForms { get; set; }
        public virtual IDbSet<Admin> Admins { get; set; }
        public NRCDataCollectionFormDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in NRCDataCollectionFormDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of NRCDataCollectionFormDbContext since ABP automatically handles it.
         */
        public NRCDataCollectionFormDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public NRCDataCollectionFormDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public NRCDataCollectionFormDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
