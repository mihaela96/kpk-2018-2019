namespace HealtyLifeApp.DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodAdditive",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 1024),
                        Code = c.String(maxLength: 100),
                        Value = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodClassification",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColoringAdditiveValue = c.Int(),
                        PreservativeValue = c.Int(),
                        AntioxidantValue = c.Int(),
                        AcidRegulatorValue = c.Int(),
                        EmulsiferValue = c.Int(),
                        ImprovingAgentValue = c.Int(),
                        FoodValue = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodClassification");
            DropTable("dbo.FoodAdditive");
        }
    }
}
