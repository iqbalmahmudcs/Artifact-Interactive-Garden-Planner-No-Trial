using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Student attends courses, marks attendance.
*/

namespace AttendanceSystem
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public ICollection<StudentCourse> EnrolledCourse { get; set; } = new List<StudentCourse>();        // a student can enroll in multiple courses ==> One to Many
    }
}
