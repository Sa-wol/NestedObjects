﻿using System;
using System.Collections.Generic;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Student legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// List of courses student is enrolled in
        /// </summary>
        public List<Course> Schedule { get; set; }

    }
}