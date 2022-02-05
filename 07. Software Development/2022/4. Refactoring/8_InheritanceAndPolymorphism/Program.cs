/// <summary>
/// Refactoring Task "InheritanceAndPolymorphism" Namespace.
/// </summary>
namespace InheritanceAndPolymorphism
{
    using InheritanceAndPolymorphism.Courses;

    /// <summary>
    /// Refactoring Task "InheritanceAndPolymorphism" program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "InheritanceAndPolymorphism" main program method.
        /// </summary>
        /// <param name="args">Given arguments</param>
        public static void Main(string[] args)
        {
            // LocalCourse
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            // OffsiteCourse
            OffsiteCourse offsiteCourse = new OffsiteCourse
            (
                "PHP and WordPress Development", // Course Name
                "Mario Peshev", // Teacher name
                new List<string>() { "Thomas", "Ani", "Steve" } // Students
            );
            Console.WriteLine(offsiteCourse);
        }
    }
}
