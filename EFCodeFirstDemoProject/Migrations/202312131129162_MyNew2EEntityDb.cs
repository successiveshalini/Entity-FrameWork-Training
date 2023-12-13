namespace EFCodeFirstDemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyNew2EEntityDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "CurrentGradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "CurrentGradeId" });
            AddColumn("dbo.Students", "CurrentGrade_GradeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "CurrentGrade_GradeId");
            AddForeignKey("dbo.Students", "CurrentGrade_GradeId", "dbo.Grades", "GradeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CurrentGrade_GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "CurrentGrade_GradeId" });
            DropColumn("dbo.Students", "CurrentGrade_GradeId");
            CreateIndex("dbo.Students", "CurrentGradeId");
            AddForeignKey("dbo.Students", "CurrentGradeId", "dbo.Grades", "GradeId", cascadeDelete: true);
        }
    }
}
