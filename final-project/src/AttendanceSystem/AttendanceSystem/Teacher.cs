using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Teacher teaches courses, checks attendance.
*/

namespace AttendanceSystem
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();    //a teacher can teach multiple courses ==> One to many
    }
}
