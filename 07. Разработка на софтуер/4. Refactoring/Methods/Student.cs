using System;

/// <summary>
/// Refactoring task "Methods" namespace.
/// </summary>
namespace Methods
{
    /// <summary>
    /// Refactoring task "Methods" class Student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Student last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Student other information.
        /// </summary>
        public string OtherInfo { get; set; }

        /// <summary>
        /// Student is older than method.
        /// </summary>
        /// <param name="other">Student</param>
        /// <returns>Boolean: true otr false</returns>
        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));

            DateTime secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));

            return firstDate < secondDate;
        }
    }
}
