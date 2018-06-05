using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class StudentGradesVM
    {
        public Student Student { get; set; }
        public IEnumerable<Subject> Subject { get; set; }
        public IEnumerable<Grade> Grades { get; set; }
    }
}
