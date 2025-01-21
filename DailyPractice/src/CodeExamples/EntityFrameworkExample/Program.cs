using EntityFrameworkExample;
using EntityFrameworkExample.Migrations;

TrainingDbContext context = new TrainingDbContext();
#region Example-1
/*
// Add a new course to the database (if needed)
Course course = new Course
{
    Title = "ASP .Net Core MVC",
    Fees = 30000,
    IsActive = false,
    ClassStartDate = DateTime.Now
};

//Uncomment this block to add the course to the database
context.Courses.Add(course);
context.SaveChanges();

// Get multiple items based on condition
var courses = context.Courses.Where(x => x.Fees >= 15000).ToList();

foreach (var c in courses)
{
    Console.WriteLine($"Title: {c.Title}, Fees: {c.Fees}, IsActive: {c.IsActive}");
}


//Data read without condition
var allCourses = context.Courses.ToList();
Console.WriteLine("All Courses:");
foreach (var c in allCourses)
{
    Console.WriteLine($"Title: {c.Title}, Fees: {c.Fees}, IsActive: {c.IsActive}");
}

//Get a single item by ID
var singleCourse = context.Courses.FirstOrDefault(x => x.Id == 1);
Console.WriteLine($"Single Course Found: Title: {singleCourse.Title}, Fees: {singleCourse.Fees}");


////Edit an existing course
//singleCourse.Fees = 10000;
//singleCourse.IsActive = true;
//context.SaveChanges();
//Console.WriteLine("Course updated successfully.");


////Delete an existing course
//context.Courses.Remove(singleCourse);
//context.SaveChanges();
*/
#endregion


#region Example-2

/*
Course course = new Course();
course.Title = "ASP .Net MVC";
course.Fees = 30000;
course.ClassStartDate = DateTime.Now;
course.IsActive = true;
course.Topic =
[
    new Topic { Name = "Getting Started", Duration = 30 },
    new Topic { Name = "ASP.Net Views", Duration = 40 }
];

context.Courses.Add(course);
context.SaveChanges();
*/

#endregion



#region Example-3

Course course = new Course();
course.Title = "Laravel";
course.Fees = 20000;
course.ClassStartDate = DateTime.Now;
course.IsActive = true;
course.Topic =
[
    new Topic { Name = "Getting Started", Duration = 30 },
    new Topic { Name = "Blade Views", Duration = 40 }
];

Student student = new Student();
student.Name = "Iqbal";
student.Cgpa = 3.22;

course.CourseStudents = new List<CourseStudent>();
course.CourseStudents.Add(new CourseStudent { Student = student });

context.Courses.Add(course);
context.SaveChanges();


#endregion
