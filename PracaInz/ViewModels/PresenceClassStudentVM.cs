using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracaInz.ViewModels
{
    public class PresenceClassStudentVM
    {
        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public IEnumerable<Presence> Presence { get; set; }
        public IEnumerable<Student> Student { get; set; }
    }
}