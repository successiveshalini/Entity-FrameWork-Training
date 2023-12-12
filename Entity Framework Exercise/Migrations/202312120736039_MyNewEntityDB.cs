namespace MyNewCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyNewEntityDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false),
                        BookTitle = c.String(nullable: false),
                        Author_AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorId)
                .Index(t => t.Author_AuthorId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        personId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.personId);
            
            CreateTable(
                "dbo.PersonBooks",
                c => new
                    {
                        Person_personId = c.Int(nullable: false),
                        Book_BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_personId, t.Book_BookId })
                .ForeignKey("dbo.People", t => t.Person_personId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookId, cascadeDelete: true)
                .Index(t => t.Person_personId)
                .Index(t => t.Book_BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors");
            DropForeignKey("dbo.PersonBooks", "Book_BookId", "dbo.Books");
            DropForeignKey("dbo.PersonBooks", "Person_personId", "dbo.People");
            DropIndex("dbo.PersonBooks", new[] { "Book_BookId" });
            DropIndex("dbo.PersonBooks", new[] { "Person_personId" });
            DropIndex("dbo.Books", new[] { "Author_AuthorId" });
            DropTable("dbo.PersonBooks");
            DropTable("dbo.People");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
