/// <summary>
/// Refactoring Task "InheritanceAndPolymorphism" Namespace.
/// </summary>
namespace Inheritance_and_Polymorphism.Courses
{
    /// <summary>
    /// Inheritance and Polymorphism course data class.
    /// </summary>
    public class OffsiteCourse : CourseData
    {
        /// <summary>
        /// Town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="courseName">Course Name</param>
        /// <param name="teacherName">Course Teacher Name</param>
        /// <param name="students">Students List</param>
        ///  <param name="town">town</param>
        public OffsiteCourse
        (
            string courseName,
            string teacherName = null,
            IList<string> students = null,
            string town = null
        ) : base(courseName, teacherName, students)
        {
            Town = null;
        }

        /// <summary>
        /// Overrive To String Method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "OffsiteCourse: " + base.ToString() + "; Town=" + Town;
        }
    }
}
