using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.Models
{
    public class Grade
    {
        public int Id { get; set; }
        [Range(1,6)]
        public byte Value { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
