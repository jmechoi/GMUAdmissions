using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GMUAdmissionProject.DAL
{
    public class Applicant
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Social Security Number")]
        public string ssn { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string phone { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string street { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public string zipcode { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime dob { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "High School Name")]
        public string hsName { get; set; }
        [Required]
        [Display(Name = "High School City")]
        public string hsCity { get; set; }

        [Required]
        [Display(Name = "Graduation Date")]
        public DateTime gradDate { get; set; }

        [Required]
        [Display(Name = "GPA")]
        [Range(3.0, 4.0,
            ErrorMessage = "Your GPA must be at least 3.0 to meet the minimum qualifications.")]
        public double gpa { get; set; }

        [Required]
        [Display(Name = "SAT Math Score")]
        [Range(0, 800)]
        public int satMath { get; set; }
        [Required]
        [Display(Name = "SAT Verbal Score")]
        [Range(0, 800)]
        public int satVerbal { get; set; }

        [Required]
        [Display(Name = "Areas of Interest")]
        public string majors { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string status { get; set; }

        [Required]
        [Display(Name = "Prospective Enrollment Semester")]
        public string enrollSemester { get; set; }
        [Required]
        [Display(Name = "Prospective Enrollment Year")]
        public string enrollYear { get; set; }

        [Required]
        [Display(Name = "Enrollment Decision")]
        public AdminDecisionType AdminDecision { get;set; }

        [Required]
        [Display(Name = "Submission Date")]
        public DateTime submissionDate { get; set; }

    public enum AdminDecisionType
    {
            New,
            Waitlist,
            Accepted,
            Rejected
        }
}
}