using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracaInz.Models;

namespace PracaInz.ViewModels
{
    public class StudentClassVM
    {
        public IEnumerable<Class> Class { get; set; }
        public Student Student { get; set; }
    }
}
