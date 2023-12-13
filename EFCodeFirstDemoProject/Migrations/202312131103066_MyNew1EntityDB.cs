namespace EFCodeFirstDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyNew1EntityDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CurrentGradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.CurrentGradeId, cascadeDelete: true)
                .Index(t => t.CurrentGradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CurrentGradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "CurrentGradeId" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
