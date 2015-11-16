using System.Data.Entity.Migrations;
namespace StudioManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudioReg : DbMigration
    {
        public override void Up()
        { 
            CreateTable(
                "dbo.StudioRegs",
                c => new
                    {
                        StudioId = c.Int(nullable: false, identity: true),
                        StudioName = c.String(),
                        StudioAddress = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        PinCode = c.String(),
                        Email = c.String(),
                        Poc = c.String(),
                        LicenseNumber = c.String(),
                        LicenseUpto = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudioRegs");
        }
    }
}
