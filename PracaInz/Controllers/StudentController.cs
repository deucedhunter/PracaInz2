using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracaInz.Models;
using System.Data.Entity;
using PracaInz.ViewModels;

namespace PracaInz.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Student
        public ActionResult Index()
        {
            var students = _context.Students.Include(s => s.Class).ToList();

            return View(students);
        }

        public ActionResult Details(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);


            return View(student);
        }

        public ActionResult New()
        {
            var myClass = _context.Classes.ToList();
            var viewModel = new StudentClassVM
            {
                Student = new Student(),
                Class = myClass
            };

            return View("StudentForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
            if (student == null) { return HttpNotFound(); }
            var viewModel = new StudentClassVM
            {
                Student = student,
                Class = _context.Classes.ToList()
            };
            return View("StudentForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Student student)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new StudentClassVM
                {
                    Student = student,
                    Class = _context.Classes.ToList()
                };
                return View("StudentForm", viewModel);
            }

            if (student.Id == 0)
            {
                _context.Students.Add(student);
            }
            else
            {
                var studentInDb = _context.Students.Single(s => s.Id == student.Id);

                studentInDb.FirstName = student.FirstName;
                studentInDb.LastName = student.LastName;
                studentInDb.Phone = student.Phone;
                studentInDb.Adress = student.Adress;
                studentInDb.City = student.City;
                studentInDb.BirthDate = student.BirthDate;
                studentInDb.ClassId = student.ClassId;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

        public ActionResult Delete(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
            if (student.Id != 0)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Student");
        }
        public ActionResult GradeList(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student.Id == 0)
                return HttpNotFound();

            var viewModel = new StudentGradesVM
            {
                Subject = _context.Subjects.ToList(),
                Student = student,
                Grades = _context.Grades.ToList()
            };

            return View(viewModel);
        }

        public ActionResult AddGrade(int studentId)
        {
            var student = _context.Students.Single(s => s.Id == studentId);
            var subject = _context.Subjects.ToList();

            var viewModel = new StudentGradeVM
            {
                Student = student,
                Subject = subject
            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveGrade(Grade grade)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new StudentGradeVM(grade)
                {
                    Student = _context.Students.Single(s => s.Id == grade.StudentId),
                    Subject = _context.Subjects.ToList()
                };

                return View("AddGrade", viewModel);
            }

            if(grade.Id == 0)
            {
                _context.Grades.Add(grade);
            }
            else
            {
                var gradeInDb = _context.Grades.Single(m => m.Id == grade.Id);
                gradeInDb.Value = grade.Value;
                gradeInDb.StudentId = grade.StudentId;
                gradeInDb.SubjectId = grade.SubjectId;
                gradeInDb.Description = grade.Description;
            }
            _context.SaveChanges();
            return RedirectToAction("GradeList", new { id = grade.StudentId });
        }

    }
}