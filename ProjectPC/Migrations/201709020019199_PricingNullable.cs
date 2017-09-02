namespace ProjectPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PricingNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "Price2", c => c.Double());
            AlterColumn("dbo.Product", "Price3", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Price3", c => c.Double(nullable: false));
            AlterColumn("dbo.Product", "Price2", c => c.Double(nullable: false));
        }
    }
}
