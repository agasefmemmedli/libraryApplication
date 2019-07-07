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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Author = c.String(maxLength: 50),
                        Count = c.Int(nullable: false),
                        CountNow = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentedBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        CalcPrice = c.Decimal(nullable: false, storeType: "money"),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        isReturn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TakedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentedBooks", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RentedBooks", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.RentedBooks", new[] { "OrderId" });
            DropIndex("dbo.RentedBooks", new[] { "BookId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.RentedBooks");
            DropTable("dbo.Books");
            DropTable("dbo.Administrators");
        }
    }
}
