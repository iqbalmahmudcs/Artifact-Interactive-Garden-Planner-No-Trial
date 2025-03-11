using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Attendance tracks student attendance for each course session
 */

namespace AttendanceSystem
{
    public class Attendence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public Course Course { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }


        public Student Student { get; set; }
        public int CourseId { get; set; }

    }
}
