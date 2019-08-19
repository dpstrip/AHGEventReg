namespace AHGEventReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sessions", "Description", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sessions", "Description", c => c.String());
        }
    }
}
