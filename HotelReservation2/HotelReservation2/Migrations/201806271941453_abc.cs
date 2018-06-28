namespace HotelReservation2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hotels", "HotelName", c => c.String(nullable: false));
            DropColumn("dbo.Hotels", "ImageData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hotels", "ImageData", c => c.Binary(nullable: false));
            AlterColumn("dbo.Hotels", "HotelName", c => c.String());
        }
    }
}
