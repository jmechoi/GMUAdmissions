namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubmissionDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "submissionDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Applicants", "dob", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Applicants", "gradDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "gradDate", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "dob", c => c.String(nullable: false));
            DropColumn("dbo.Applicants", "submissionDate");
        }
    }
}
