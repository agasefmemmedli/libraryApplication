namespace Library_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        FullName = c.String(maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Gender = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentedBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdministratorId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        TakingDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        InfactDate = c.DateTime(),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administrators", t => t.AdministratorId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.AdministratorId)
                .Index(t => t.CustomerId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Author = c.String(maxLength: 50),
                        Count = c.Int(nullable: false),
                        Position = c.String(maxLength: 50),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Gender = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentedBooks", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RentedBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.RentedBooks", "AdministratorId", "dbo.Administrators");
            DropIndex("dbo.RentedBooks", new[] { "BookId" });
            DropIndex("dbo.RentedBooks", new[] { "CustomerId" });
            DropIndex("dbo.RentedBooks", new[] { "AdministratorId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Books");
            DropTable("dbo.RentedBooks");
            DropTable("dbo.Administrators");
        }
    }
}
