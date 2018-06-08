using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class StudentGradeVM
    {
        public Student Student { get; set; }
        public IEnumerable<Subject> Subject { get; set; }


        public int Id { get; set; }

        [Range(1, 6)]
        public byte Value { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public StudentGradeVM()
        {
            Id = 0;
        }

        public StudentGradeVM(Grade grade)
        {
            Id = grade.Id;
            Value = grade.Value;
            Description = grade.Description;
            StudentId = grade.StudentId;
            SubjectId = grade.SubjectId;
        }

    }

    
}
