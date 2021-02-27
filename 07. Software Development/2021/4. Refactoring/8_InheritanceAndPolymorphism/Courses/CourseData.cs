using System.Collections.Generic;

namespace InheritanceAndPolymorphism.Courses
{
    /// <summary>
    /// Inheritance and Polymorphism course data class.
    /// </summary>
    public class CourseData
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public IList<string> Students { get; set; }

        /// <summary>
        /// Inheritance and Polymorphism course data class constructor.
        /// </summary>
        /// <param name="name">Name</param>
        public CourseData(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        /// <summary>
        /// Inheritance and Polymorphism course data class constructor.
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        public CourseData(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        /// <summary>
        /// Inheritance and Polymorphism course data class constructor
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        /// <param name="students">Students</param>
        public CourseData(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>
        /// Inheritance and Polymorphism couruse data class get student as string method
        /// </summary>
        /// <returns>STudent</returns>
        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
