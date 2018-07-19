using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public Student(int studentId, string name)
        {
            this.StudentId = studentId;
            this.Name = name;
        }
    }
}