using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class SubjectTeacherVM
    {
        public IEnumerable<Subject> Subject { get; set; }
        public IEnumerable<Class> Class { get; set; }


        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }


        public SubjectTeacherVM()
        {
            TeacherId = 0;
        }

        public SubjectTeacherVM(Teacher teacher)
        {
            TeacherId = teacher.TeacherId;
            FirstName = teacher.FirstName;
            LastName = teacher.LastName;
            Adress = teacher.Adress;
            Phone = teacher.Phone;
            SubjectId = teacher.SubjectId;
            ClassId = teacher.ClassId;
        }
    }
}
