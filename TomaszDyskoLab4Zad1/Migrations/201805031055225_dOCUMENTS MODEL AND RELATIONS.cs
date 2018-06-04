namespace TomaszDyskoLab4Zad1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dOCUMENTSMODELANDRELATIONS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        TemplateId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Templates", t => t.TemplateId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.TemplateId)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "AuthorId", "dbo.Users");
            DropForeignKey("dbo.Documents", "TemplateId", "dbo.Templates");
            DropIndex("dbo.Documents", new[] { "AuthorId" });
            DropIndex("dbo.Documents", new[] { "TemplateId" });
            DropTable("dbo.Documents");
        }
    }
}
