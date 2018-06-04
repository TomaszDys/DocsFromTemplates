namespace TomaszDyskoLab4Zad1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addimagetodocuments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "Image", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "Image");
        }
    }
}
