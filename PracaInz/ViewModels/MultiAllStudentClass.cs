using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class MultiAllStudentClass
    {
        public IEnumerable<Class> Class { get; set; }
        public IEnumerable<Student> Student { get; set; }
    }
}
