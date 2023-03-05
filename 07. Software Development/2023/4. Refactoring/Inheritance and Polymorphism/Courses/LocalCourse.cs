using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Polymorphism.Courses
{
    public class LocalCourse : CourseData
    {
        /// <summary>
        /// Lab
        /// </summary>
        public string Lab { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="courseName">Course Name</param>
        /// <param name="teacherName">Course Teacher Name</param>
        /// <param name="students">Students List</param>
        /// <param name="lab">Lab</param>
        public LocalCourse
        (
            string courseName,
            string teacherName = null,
            IList<string> students = null,
            string lab = null
        ) : base(courseName, teacherName, students)
        {
            Lab = lab;
        }

        /// <summary>
        /// Overrive To String Method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "LocalCourse: " + base.ToString() + "; Lab=" + Lab + ")";
        }
    }
}
