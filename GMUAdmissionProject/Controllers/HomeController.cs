using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GMUAdmissionProject.Controllers
{
    public class HomeController : Controller
    {
        private DAL.AdmissionsDBContext db = new DAL.AdmissionsDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Apply()
        {
            //DAL.Applicant applicant = new DAL.Applicant();
            //applicant.submissionDate = DateTime.Today;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply([Bind(Include = "Id,FirstName,MiddleName,LastName,ssn,email,phone,street,city,state,zipcode,dob,gender,hsName,hsCity,gradDate,gpa,satMath,satVerbal,majors,status,enrollSemester,enrollYear,decision")] DAL.Applicant applicant)
        {
            

            if (ModelState.IsValid)
            {
                applicant.submissionDate = DateTime.Today;
                DAL.Applicant matchingApp = db.Applicants.Where(cm => string.Compare(cm.ssn, applicant.ssn, true) == 0).FirstOrDefault();

                if (applicant == null)
                {
                    return HttpNotFound();
                }

                if (matchingApp != null)
                {
                    ModelState.AddModelError("ssn", "Applicant must be unique.");
                    return View(applicant);
                }

                int satScores = applicant.satMath + applicant.satVerbal;
                int satMin = 1000;

                if (satScores <= satMin)
                {
                    ModelState.AddModelError("satVerbal", "Your SAT scores must total to more than 1000 to meet the minimum qualifications.");
                    return View(applicant);
                }


                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicant);
        }


    }
}