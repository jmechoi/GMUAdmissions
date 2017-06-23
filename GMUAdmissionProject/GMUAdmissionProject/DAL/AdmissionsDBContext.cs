using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GMUAdmissionProject.DAL
{
    public class AdmissionsDBContext:DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
    }
}