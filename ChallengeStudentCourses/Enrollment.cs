using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Enrollment
    {
        public Course Course { get; set; }
        public int Grade { get; set; }

        public Enrollment(Course course, int grade)
        {
            Course = course;
            Grade = grade;
        }
    }
}