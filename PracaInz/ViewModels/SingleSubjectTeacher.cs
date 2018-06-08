using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracaInz.ViewModels
{
    public class SingleSubjectTeacher
    {
        public Subject Subject { get; set; }

        public int? TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int? SubjectId { get; set; }


        public SingleSubjectTeacher()
        {
            TeacherId = 0;
        }

        public SingleSubjectTeacher(Teacher teacher)
        {
            TeacherId = teacher.TeacherId;
            FirstName = teacher.FirstName;
            LastName = teacher.LastName;
            Adress = teacher.Adress;
            Phone = teacher.Phone;
            SubjectId = teacher.SubjectId;
        }
    }

}