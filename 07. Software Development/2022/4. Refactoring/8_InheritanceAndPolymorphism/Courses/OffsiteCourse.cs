using System.Text;

/// <summary>
/// Refactoring Task "InheritanceAndPolymorphism" Namespace.
/// </summary>
namespace InheritanceAndPolymorphism.Courses
{
    /// <summary>
    /// Inheritance and Polymorphism offline course class.
    /// </summary>
    public class OffsiteCourse : CourseData
    {
        public string Town { get; set; }

        /// <summary>
        /// Inheritance and Polymorphism offline course class constructor.
        /// </summary>
        /// <param name="name">Course name</param>
        public OffsiteCourse(string name) : base(name)
        {
            // nope
        }

        /// <summary>
        /// Inheritance and Polymorphism offline course class constructor.
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        public OffsiteCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
            // nope
        }

        /// <summary>
        /// Inheritance and Polymorphism offline course class constructor.
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        /// <param name="students">Students</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            // nope
        }

        /// <summary>
        /// Inheritance and Polymorphism offline course class override to string method.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
