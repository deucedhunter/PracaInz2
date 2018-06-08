using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.Models
{
    public class Presence
    {
        public int Id { get; set; }
        [Required]
        public bool IsPresent { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public int? ClassId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Class Class { get; set; } 

    }
}
