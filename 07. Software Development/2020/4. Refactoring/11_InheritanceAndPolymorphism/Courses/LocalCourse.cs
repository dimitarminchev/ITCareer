using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : CourseData
    {

        public string Lab { get; set; }

        public LocalCourse(string name) :
            base(name)
        {
        }

        public LocalCourse(string courseName, string teacherName) :
            base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students) :
            base(courseName, teacherName, students)
        {
        }

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
