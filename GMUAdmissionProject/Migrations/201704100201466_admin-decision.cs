namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admindecision : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "AdminDecision", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "AdminDecision");
        }
    }
}
