using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GMUAdmissionProject.DAL;

namespace GMUAdmissionProject.Controllers
{
    [Authorize]
    public class ApplicantsController : Controller
    {
        private AdmissionsDBContext db = new AdmissionsDBContext();

        // GET: Applicants
        public ActionResult Index(string search)
        {
            var applicants = from a in db.Applicants select a;

            if (!String.IsNullOrEmpty(search))
            {
                applicants = applicants.Where(s => s.ssn.Contains(search));
            }
            

            ViewBag.Search = search;

            //ViewBag.ssn = new SelectList(ssns);

            //return View(db.Applicants.ToList());
            return View(applicants);
        }

        // GET: Applicants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicants/Create
        public ActionResult Create()
        {
            //Applicant applicant = new Applicant();
           // applicant.submissionDate = DateTime.Today;
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,MiddleName,LastName,ssn,email,phone,street,city,state,zipcode,dob,gender,hsName,hsCity,gradDate,gpa,satMath,satVerbal,majors,status,enrollSemester,enrollYear,decision")] Applicant applicant)
        {
            

            if (ModelState.IsValid)
            {
                
                Applicant matchingApp = db.Applicants.Where(cm => string.Compare(cm.ssn, applicant.ssn, true) == 0).FirstOrDefault();

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

                if (satScores < satMin)
                {
                    ModelState.AddModelError("satVerbal", "Your SAT scores must total to more than 1000 to meet the minimum qualifications.");
                    return View(applicant);
                }

                applicant.submissionDate = DateTime.Today;
                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        // GET: Applicants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,MiddleName,LastName,ssn,email,phone,street,city,state,zipcode,dob,gender,hsName,hsCity,gradDate,gpa,satMath,satVerbal,majors,status,enrollSemester,enrollYear,AdminDecision")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                applicant.submissionDate = DateTime.Today;
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicant);
        }

        // GET: Applicants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Applicants.Find(id);
            db.Applicants.Remove(applicant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
