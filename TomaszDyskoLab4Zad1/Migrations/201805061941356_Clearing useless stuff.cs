namespace TomaszDyskoLab4Zad1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clearinguselessstuff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documents", "TemplateId", "dbo.Templates");
            DropIndex("dbo.Documents", new[] { "TemplateId" });
            AlterColumn("dbo.Documents", "TemplateId", c => c.Int());
            CreateIndex("dbo.Documents", "TemplateId");
            AddForeignKey("dbo.Documents", "TemplateId", "dbo.Templates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "TemplateId", "dbo.Templates");
            DropIndex("dbo.Documents", new[] { "TemplateId" });
            AlterColumn("dbo.Documents", "TemplateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Documents", "TemplateId");
            AddForeignKey("dbo.Documents", "TemplateId", "dbo.Templates", "Id", cascadeDelete: true);
        }
    }
}
