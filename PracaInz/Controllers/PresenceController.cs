using PracaInz.Models;
using PracaInz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracaInz.Controllers
{
    public class PresenceController : Controller
    {
        private ApplicationDbContext _contex;
        public PresenceController()
        {
            _contex = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }

        //GET: Presence/Details/5
        public ActionResult CheckPresenceClass(Class Class, Subject Subject)
        {
            var singleClass = Class;
            var presence = _contex.Presence.Where(p => p.ClassId == singleClass.Id).ToList();
            if (singleClass.Id == 0)
                return HttpNotFound();

            var viewModel = new PresenceClassStudentVM()
            {
                Class = singleClass,
                Presence = presence,
                Subject = Subject,
                Student = _contex.Students.Where(s => s.ClassId == singleClass.Id).ToList()
            };

            return View("CheckPresence", viewModel);
        }

        // GET: Presence/Create
        public ActionResult ChooseSubject(int classId)
        {

            var singleClass = _contex.Classes.Single(c => c.Id == classId);
            var subject = _contex.Subjects.ToList();
            var viewModel = new ClassSubjectsVM
            {
                Class = singleClass,
                Subject = subject
            };

            return View(viewModel);
        }

    }
}
