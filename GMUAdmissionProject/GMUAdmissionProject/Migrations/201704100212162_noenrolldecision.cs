namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noenrolldecision : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Applicants", "decision");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applicants", "decision", c => c.String(nullable: false));
        }
    }
}
