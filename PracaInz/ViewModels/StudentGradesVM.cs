﻿using PracaInz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInz.ViewModels
{
    public class StudentGradesVM
    {
        public Student Student { get; set; }
        public IEnumerable<Grade> Grade { get; set; }
    }
}