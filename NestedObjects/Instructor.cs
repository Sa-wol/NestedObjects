using System;
namespace NestedObjects
{
    /// <summary>
    /// Represents an individual instructor
    /// </summary>
    public class Instructor
    {
        /// <summary>
        /// Instructor legal first and last name
        /// Example: Jane Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Company email address
        /// Exmaple: Jane.Doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
    }
}