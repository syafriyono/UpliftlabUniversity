﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpliftlabUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstMidName { get; set; }
        public string Lastname { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}