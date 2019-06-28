namespace Library_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentedBooks", "InfactDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RentedBooks", "InfactDate");
        }
    }
}
