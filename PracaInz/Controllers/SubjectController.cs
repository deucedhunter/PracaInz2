using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracaInz.Models;

namespace PracaInz.Controllers
{
    public class SubjectController : Controller
    {
        private ApplicationDbContext _context;

        public SubjectController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Subject
        public ActionResult Index()
        {
            var subjects = _context.Subjects.ToList();


            return View(subjects);
        }
        public ActionResult Details(int id)
        {
            var subject = _context.Subjects.FirstOrDefault(s => s.Id == id);

            if (subject == null)
                return HttpNotFound();

            return View(subject);
        }

        public ActionResult New()
        {
            var subject = new Subject();
            return View("subjectForm", subject);
        }

        public ActionResult Edit(int id)
        {
            var subject = _context.Subjects.Single(s => s.Id == id);

            if (subject == null)
                return HttpNotFound();

            return View("subjectForm", subject);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Subject subject)
        {
            if (!ModelState.IsValid)
            {
                return View("subjectForm", subject);
            }
            if(subject.Id == 0)
                _context.Subjects.Add(subject);
            else
            {
                var subjectInDb = _context.Subjects.SingleOrDefault(s => s.Id == subject.Id);
                subjectInDb.Name = subject.Name;
                subjectInDb.Description = subject.Description;
            }

                _context.SaveChanges();

            return RedirectToAction("Index", "Subject");
        }

        public ActionResult Delete(int id)
        {
            var subject = _context.Subjects.Single(s => s.Id == id);
            if (subject.Id != 0)
            {
                _context.Subjects.Remove(subject);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Subject");
        }

    }
}