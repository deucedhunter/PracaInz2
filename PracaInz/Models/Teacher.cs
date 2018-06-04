using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public int SubjectId { get; set; }
        public int ClassId { get; set; }


        public virtual Subject Subject { get; set; }
        public virtual Class Class { get; set; }
    }
}
