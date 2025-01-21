using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public List<CourseStudent> CourseStudents { get; set; }
    }
}
