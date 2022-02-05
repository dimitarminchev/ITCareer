using System.Text;

/// <summary>
/// Refactoring Task "InheritanceAndPolymorphism" Namespace.
/// </summary>
namespace InheritanceAndPolymorphism.Courses
{
    /// <summary>
    /// Inheritance and Polymorphism local course data class.
    /// </summary>
    public class LocalCourse : CourseData
    {
        public string Lab { get; set; }

        /// <summary>
        /// Inheritance and Polymorphism local course data class constructor.
        /// </summary>
        /// <param name="name">Name</param>
        public LocalCourse(string name) : base(name)
        {
            // nope
        }

        /// <summary>
        /// Inheritance and Polymorphism local course data class constructor.
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        public LocalCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
            // nope
        }

        /// <summary>
        /// Inheritance and Polymorphism local course data class constructor.
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        /// <param name="students">Students</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            // nope
        }

        /// <summary>
        /// Inheritance and Polymorphism local course data class override to string method.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
