using System;
using System.Collections.Generic;

namespace NestedObjects
{
    public class Course
    {
        /// <summary>
        /// The full title of the course
        /// Example: CPW 212 - Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course catalog official description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits awarded for passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// All the students currently enrolled in the class
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}