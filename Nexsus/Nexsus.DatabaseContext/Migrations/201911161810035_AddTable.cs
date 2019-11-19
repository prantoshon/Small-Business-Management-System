namespace Nexsus.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplierModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SupplierModels");
        }
    }
}
