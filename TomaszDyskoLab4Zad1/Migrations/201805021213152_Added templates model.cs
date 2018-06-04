namespace TomaszDyskoLab4Zad1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedtemplatesmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Templates");
        }
    }
}
