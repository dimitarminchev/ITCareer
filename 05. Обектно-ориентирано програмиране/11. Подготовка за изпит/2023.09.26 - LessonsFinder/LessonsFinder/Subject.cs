using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Subject
{
    private string name;
    public string Name
    {
        get => name;
        set
        {
            if (value == null || value.Length < 2 || value.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            name = value;
        }
    }

    private List<Lesson> lessons;

    public Subject(string name)
    {
        this.Name = name;
        this.lessons = new List<Lesson>();
    }

    public void AddLesson(Lesson lesson)
    {
        this.lessons.Add(lesson);
    }

    public void AddRate(string title, int rate)
    {
        var lesson = this.lessons.FirstOrDefault(l => l.Title == title);
        if (lesson == null)
            throw new ArgumentException("Lesson not found!");
        lesson.AddRating(rate);
    }

    public double AverageRating()
    {
        var ratedLessons = this.lessons.Where(l => l.Ratings.Count > 0).ToList();
        if (!ratedLessons.Any()) return 0.0;
        return ratedLessons.Average(l => l.Rating);
    }

    public List<Lesson> GetLessonsByTeacher(string teacher)
    {
        return this.lessons
            .Where(l => l.Teacher == teacher)
            .OrderByDescending(l => l.Duration)
            .ToList();
    }

    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
    {
        return this.lessons
            .Where(l => l.Duration >= from && l.Duration <= to)
            .OrderByDescending(l => l.Rating) // by rating descending
            .ToList();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Subject {this.Name}");
        sb.Append($"Total Lessons: {this.lessons.Count}");
        return sb.ToString();
    }
}