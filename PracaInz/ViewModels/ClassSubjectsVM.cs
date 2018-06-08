using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class ClassSubjectsVM
    {
        public Class Class { get; set; }
        public IEnumerable<Subject> Subject { get; set; }
        public int? SubjectId { get; set; }

    }
}
