using PracaInz.Models;
using PracaInz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PracaInz.Controllers
{
    public class TeacherController : Controller
    {
        ApplicationDbContext _context;

        public TeacherController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new SubjectTeacherVM(teacher)
                {
                    Subject = _context.Subjects.ToList()
                };
                return View("formTeacher", viewModel);
            }

            if (teacher.TeacherId == 0)
                _context.Teachers.Add(teacher);
            else
            {
                var teacherInDb = _context.Teachers.Single(t => t.TeacherId == teacher.TeacherId);
                teacherInDb.FirstName = teacher.FirstName;
                teacherInDb.LastName = teacher.LastName;
                teacherInDb.Adress = teacher.Adress;
                teacherInDb.Phone = teacher.Phone;
                teacherInDb.SubjectId = teacher.SubjectId;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Teacher");
        }
        //GET: Teacher
        public ActionResult Index()
        {
            var teachers = _context.Teachers.ToList();
            return View(teachers);
        }
        public ActionResult Details(int id)
        {
            var teachers = _context.Teachers.Include(s => s.Subject).SingleOrDefault(t => t.TeacherId == id);

            if (teachers == null)
                return HttpNotFound();

            var viewModel = new SingleSubjectTeacher(teachers)
            {
                Subject = _context.Subjects.SingleOrDefault(s=>s.Id==teachers.SubjectId)
            };

            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            var teachers = _context.Teachers.SingleOrDefault(t => t.TeacherId == id);

            var viewModel = new SubjectTeacherVM(teachers)
            {
                Subject = _context.Subjects.ToList()
            };

            return View("formTeacher", viewModel);
        }




    }
}