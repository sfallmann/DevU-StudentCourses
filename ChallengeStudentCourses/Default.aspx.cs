using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {

        Student studentA = new Student(234123, "Eddie Van Halen");
        Student studentB = new Student(123456, "Conan Cimmerian");
        Student studentC = new Student(987567, "Bugs Bunny");

        Course courseA = new Course(132, "Intro to Mathematics");
        Course courseB = new Course(404, "Finding HTTP Codes");
        Course courseC = new Course(123, "Counting for Humanities");

        StringBuilder sb = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
 

            List<Course> courses = new List<Course>
            {
                courseA,
                courseB,
                courseC
            };

            courseA.Students = new List<Student>() { studentA, studentB };
            courseB.Students = new List<Student>() { studentA, studentC };
            courseC.Students = new List<Student>() { studentB, studentC };

            sb.Clear();
            foreach (var course in courses)
            {
                sb.Append($"Name: {course.Name} - CourseID {course.CourseId}<br/>");

                foreach (var student in course.Students)
                {
                    sb.Append("==================<br/>");
                    sb.Append($"{student.Name} - {student.StudentId}<br/>");
                }

                sb.Append("<hr/>");

            }

            resultLabel.Text = sb.ToString();
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(studentA.StudentId, studentA);
            students.Add(studentB.StudentId, studentB);
            students.Add(studentC.StudentId, studentC);

            studentA.Courses = new List<Course>()
            {
                courseA,
                courseB
            };
            studentB.Courses = new List<Course>()
            {
                courseA,
                courseC
            };
            studentC.Courses = new List<Course>()
            {
                courseB,
                courseC
            };

            sb.Clear();

            foreach (var student in students)
            {
                sb.Append($"Name: {student.Value.Name} - CourseID {student.Key}<br/>");
                
                foreach (var course in student.Value.Courses)
                {
                    sb.Append("==================<br/>");
                    sb.Append($"{course.Name} - {course.CourseId}<br/>");
                }

                sb.Append("<hr/>");

            }
            
            resultLabel.Text = sb.ToString();
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            studentA.Enrollments = new List<Enrollment>()
            {
                new Enrollment(courseA, 95)
            };
            studentB.Enrollments = new List<Enrollment>()
            {
                new Enrollment(courseB, 89),
                new Enrollment(courseC, 77)
            };
            studentC.Enrollments = new List<Enrollment>()
            {
                new Enrollment(courseA, 55),
                new Enrollment(courseC, 100)
            };

            List<Student> students = new List<Student>() { studentA, studentB, studentC };

            sb.Clear();

            foreach (var student in students)
            {
                sb.Append($"Name: {student.Name}<br/>");

                foreach (var enrollment in student.Enrollments)
                {
                    sb.Append("==================<br/>");
                    sb.Append($"{enrollment.Course.Name} - {enrollment.Grade}<br/>");
                }

                sb.Append("<hr/>");
            }

            resultLabel.Text = sb.ToString();
        }
    }
}