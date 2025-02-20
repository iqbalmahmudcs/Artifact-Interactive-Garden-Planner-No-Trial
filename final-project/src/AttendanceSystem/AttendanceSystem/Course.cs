using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Course has a name, fees, teacher, students
 */

namespace AttendanceSystem
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Fees { get; set; }

        //Foreign Key for Teacher Table
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }

        public List<Student> Studdents { get; set; } = new List<Student>();        //Enrolled Students in a course
        
        public List<ClassSchedule> Schedules { get; set; } = new List<ClassSchedule>();

    }
}
