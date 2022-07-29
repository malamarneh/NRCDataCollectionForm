namespace NRCDataCollectionForm.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sec.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false, maxLength: 256),
                        Name = c.String(maxLength: 256),
                        Password = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Admin_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Sec.Admin",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Admin_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
