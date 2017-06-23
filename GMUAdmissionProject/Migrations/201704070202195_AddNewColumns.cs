namespace GMUAdmissionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "ssn", c => c.String());
            AddColumn("dbo.Applicants", "email", c => c.String());
            AddColumn("dbo.Applicants", "phone", c => c.String());
            AddColumn("dbo.Applicants", "street", c => c.String());
            AddColumn("dbo.Applicants", "city", c => c.String());
            AddColumn("dbo.Applicants", "state", c => c.String());
            AddColumn("dbo.Applicants", "zipcode", c => c.String());
            AddColumn("dbo.Applicants", "dob", c => c.String());
            AddColumn("dbo.Applicants", "gender", c => c.String());
            AddColumn("dbo.Applicants", "hsName", c => c.String());
            AddColumn("dbo.Applicants", "hsCity", c => c.String());
            AddColumn("dbo.Applicants", "gradDate", c => c.String());
            AddColumn("dbo.Applicants", "gpa", c => c.Double(nullable: false));
            AddColumn("dbo.Applicants", "satMath", c => c.Int(nullable: false));
            AddColumn("dbo.Applicants", "satVerbal", c => c.Int(nullable: false));
            AddColumn("dbo.Applicants", "majors", c => c.String());
            AddColumn("dbo.Applicants", "status", c => c.String());
            AddColumn("dbo.Applicants", "enrollSemester", c => c.String());
            AddColumn("dbo.Applicants", "enrollYear", c => c.String());
            AddColumn("dbo.Applicants", "decision", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "decision");
            DropColumn("dbo.Applicants", "enrollYear");
            DropColumn("dbo.Applicants", "enrollSemester");
            DropColumn("dbo.Applicants", "status");
            DropColumn("dbo.Applicants", "majors");
            DropColumn("dbo.Applicants", "satVerbal");
            DropColumn("dbo.Applicants", "satMath");
            DropColumn("dbo.Applicants", "gpa");
            DropColumn("dbo.Applicants", "gradDate");
            DropColumn("dbo.Applicants", "hsCity");
            DropColumn("dbo.Applicants", "hsName");
            DropColumn("dbo.Applicants", "gender");
            DropColumn("dbo.Applicants", "dob");
            DropColumn("dbo.Applicants", "zipcode");
            DropColumn("dbo.Applicants", "state");
            DropColumn("dbo.Applicants", "city");
            DropColumn("dbo.Applicants", "street");
            DropColumn("dbo.Applicants", "phone");
            DropColumn("dbo.Applicants", "email");
            DropColumn("dbo.Applicants", "ssn");
        }
    }
}
