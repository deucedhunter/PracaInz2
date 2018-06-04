using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class MultiStudentClassMV
    {
        public IEnumerable<Student> Student { get; set; }
        public Class Class { get; set; }
    }
}
