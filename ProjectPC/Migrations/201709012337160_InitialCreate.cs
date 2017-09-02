namespace ProjectPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductDescription = c.String(nullable: false),
                        Size1 = c.Boolean(nullable: false),
                        Size2 = c.Boolean(nullable: false),
                        Size3 = c.Boolean(nullable: false),
                        Price1 = c.Double(nullable: false),
                        Price2 = c.Double(nullable: false),
                        Price3 = c.Double(nullable: false),
                        Image = c.Binary(),
                        ImageType = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
