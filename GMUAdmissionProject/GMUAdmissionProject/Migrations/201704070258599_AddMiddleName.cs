namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMiddleName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "MiddleName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "ssn", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "phone", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "street", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "city", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "state", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "zipcode", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "dob", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "gender", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "hsName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "hsCity", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "gradDate", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "majors", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "status", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "enrollSemester", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "enrollYear", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "decision", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "decision", c => c.String());
            AlterColumn("dbo.Applicants", "enrollYear", c => c.String());
            AlterColumn("dbo.Applicants", "enrollSemester", c => c.String());
            AlterColumn("dbo.Applicants", "status", c => c.String());
            AlterColumn("dbo.Applicants", "majors", c => c.String());
            AlterColumn("dbo.Applicants", "gradDate", c => c.String());
            AlterColumn("dbo.Applicants", "hsCity", c => c.String());
            AlterColumn("dbo.Applicants", "hsName", c => c.String());
            AlterColumn("dbo.Applicants", "gender", c => c.String());
            AlterColumn("dbo.Applicants", "dob", c => c.String());
            AlterColumn("dbo.Applicants", "zipcode", c => c.String());
            AlterColumn("dbo.Applicants", "state", c => c.String());
            AlterColumn("dbo.Applicants", "city", c => c.String());
            AlterColumn("dbo.Applicants", "street", c => c.String());
            AlterColumn("dbo.Applicants", "phone", c => c.String());
            AlterColumn("dbo.Applicants", "email", c => c.String());
            AlterColumn("dbo.Applicants", "ssn", c => c.String());
            AlterColumn("dbo.Applicants", "LastName", c => c.String());
            AlterColumn("dbo.Applicants", "FirstName", c => c.String());
            DropColumn("dbo.Applicants", "MiddleName");
        }
    }
}
