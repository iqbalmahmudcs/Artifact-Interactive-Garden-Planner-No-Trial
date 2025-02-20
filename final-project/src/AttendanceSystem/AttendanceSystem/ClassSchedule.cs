using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ClassSchedule defines when classes occur
 */

namespace AttendanceSystem
{
    public class ClassSchedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [Required]
        public string Day { get; set; }
        [Required]
        public TimeSpan StartTime { get; set; }
        [Required]
        public int TotalClasses { get; set; }

    }
}
