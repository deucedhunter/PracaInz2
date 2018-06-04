using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracaInz.Models;

namespace PracaInz.ViewModels
{
    public class StudentSubjectVM
    {
        public Subject Subject { get; set; }
        public IEnumerable<Student> Student { get; set; }
    }
}