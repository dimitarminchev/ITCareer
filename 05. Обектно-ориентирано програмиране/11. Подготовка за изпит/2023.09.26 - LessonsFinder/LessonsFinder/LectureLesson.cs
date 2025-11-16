using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LectureLesson : Lesson
{
    private string location;
    public string Location
    {
        get => location;
        set
        {
            if (value == null || value.Length == 0)
                throw new ArgumentException("Location should be provided!");
            location = value;
        }
    }

    public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location)
        : base(title, duration, grade, difficulty, teacher)
    {
        this.Location = location;
    }

    public override string ToString()
    {
        return base.ToString() + $" @ Onsite: {this.Location}";
    }
}