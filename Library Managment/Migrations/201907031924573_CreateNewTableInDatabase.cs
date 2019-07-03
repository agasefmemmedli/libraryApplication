namespace Library_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNewTableInDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RentedBooks", "AdministratorId", "dbo.Administrators");
            DropForeignKey("dbo.RentedBooks", "CustomerId", "dbo.Customers");
            DropIndex("dbo.RentedBooks", new[] { "AdministratorId" });
            DropIndex("dbo.RentedBooks", new[] { "CustomerId" });
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
            
            AddColumn("dbo.RentedBooks", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.RentedBooks", "OrderId");
            AddForeignKey("dbo.RentedBooks", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
            DropColumn("dbo.Administrators", "Gender");
            DropColumn("dbo.RentedBooks", "AdministratorId");
            DropColumn("dbo.RentedBooks", "CustomerId");
            DropColumn("dbo.RentedBooks", "TakingDate");
            DropColumn("dbo.Books", "Position");
            DropColumn("dbo.Customers", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Gender", c => c.String(maxLength: 50));
            AddColumn("dbo.Books", "Position", c => c.String(maxLength: 50));
            AddColumn("dbo.RentedBooks", "TakingDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.RentedBooks", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.RentedBooks", "AdministratorId", c => c.Int(nullable: false));
            AddColumn("dbo.Administrators", "Gender", c => c.String(maxLength: 50));
            DropForeignKey("dbo.RentedBooks", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.RentedBooks", new[] { "OrderId" });
            DropColumn("dbo.RentedBooks", "OrderId");
            DropTable("dbo.Orders");
            CreateIndex("dbo.RentedBooks", "CustomerId");
            CreateIndex("dbo.RentedBooks", "AdministratorId");
            AddForeignKey("dbo.RentedBooks", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RentedBooks", "AdministratorId", "dbo.Administrators", "Id", cascadeDelete: true);
        }
    }
}
