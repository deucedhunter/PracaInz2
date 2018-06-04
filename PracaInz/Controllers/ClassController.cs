using PracaInz.Models;
using PracaInz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracaInz.Controllers
{
    public class ClassController : Controller
    {
        private ApplicationDbContext _context;

        public ClassController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Class
        public ActionResult Index()
        {

            var viewModel = new BothMultiStudentClassVM
            {
                Class = _context.Classes.ToList(),
                Student = _context.Students.ToList()
            };

            return View(viewModel);
        }

        // GET: List
        public ActionResult List(int id)
        {
            var singleClass = _context.Classes.Single(c => c.Id == id);

            if (singleClass.Id == 0)
                return HttpNotFound();

            var singleStudent = _context.Students.Where(s => s.ClassId == singleClass.Id).ToList();
            ViewBag.ClassName = singleClass.Name;

            return View(singleStudent);
        }
    }
}


