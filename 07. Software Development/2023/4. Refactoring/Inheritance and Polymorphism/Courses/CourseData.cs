using System.Text;

/// <summary>
/// Refactoring Task "InheritanceAndPolymorphism" Namespace.
/// </summary>
namespace Inheritance_and_Polymorphism.Courses
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
        /// Constructor
        /// </summary>
        /// <param name="courseName">Course Name</param>
        /// <param name="teacherName">Course Teacher Name</param>
        /// <param name="students">Students List</param>
        public CourseData
        (
            string courseName, 
            string teacherName = null,
            IList<string> students = null
        )
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>
        /// Inheritance and Polymorphism couruse data class get student as string method
        /// </summary>
        /// <returns>Student</returns>
        private string GetStudentsAsString()
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

        /// <summary>
        /// Overrive To String Method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Name = ");
            sb.Append(this.Name);
            if (this.TeacherName != null)
            {
                sb.Append("; Teacher = ");
                sb.Append(this.TeacherName);
            }
            sb.Append("; Students = ");
            sb.Append(this.GetStudentsAsString());

            return sb.ToString();
        }

    }
}
