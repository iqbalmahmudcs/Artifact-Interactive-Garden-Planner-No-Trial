using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Student Course many to many relationship Table
 */

namespace AttendanceSystem
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }


        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
