using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Controller
{
    private readonly Dictionary<string, Subject> subjects;

    public Controller()
    {
        subjects = new Dictionary<string, Subject>();
    }

    public string AddSubject(List<string> args)
    {
        string name = args[0];
        if (subjects.ContainsKey(name))
            return "Subject already exists!";
        var subject = new Subject(name);
        subjects.Add(name, subject);
        return $"Created Subject {name}!";
    }

    public string AddLesson(List<string> args)
    {
        string subjectName = args[0];
        string title = args[1];
        int duration = int.Parse(args[2]);
        int grade = int.Parse(args[3]);
        int difficulty = int.Parse(args[4]);
        string teacher = args[5];
        string type = args[6];

        Subject subject = subjects[subjectName];

        Lesson lesson;
        if (type == "online")
        {
            string platform = args[7];
            lesson = new OnlineLesson(title, duration, grade, difficulty, teacher, platform);
        }
        else if (type == "lecture" || type == "onsite")
        {
            string location = args[7];
            lesson = new LectureLesson(title, duration, grade, difficulty, teacher, location);
        }
        else if (type == "onsite")
        {
            string location = args[7];
            lesson = new LectureLesson(title, duration, grade, difficulty, teacher, location);
        }
        else
        {
            throw new ArgumentException("Invalid lesson type");
        }

        subject.AddLesson(lesson);
        return $"Created Lesson {title} in Subject {subjectName}!";
    }

    public string RateLesson(List<string> args)
    {
        string subjectName = args[0];
        string title = args[1];
        int rate = int.Parse(args[2]);

        Subject subject = subjects[subjectName];
        subject.AddRate(title, rate);
        return $"Rated {title} with {rate} rate.";
    }

    public string GetAverageRating(List<string> args)
    {
        string subjectName = args[0];
        Subject subject = subjects[subjectName];
        double avg = subject.AverageRating();
        return $"The average rating is: {avg:F2}";
    }

    public string GetLessonsByTeacher(List<string> args)
    {
        string subjectName = args[0];
        string teacher = args[1];
        Subject subject = subjects[subjectName];
        var lessons = subject.GetLessonsByTeacher(teacher);
        if (!lessons.Any()) return string.Empty;
        return string.Join(Environment.NewLine + Environment.NewLine, lessons.Select(l => l.ToString()));
    }

    public string GetLessonsBetweenDuration(List<string> args)
    {
        string subjectName = args[0];
        int from = int.Parse(args[1]);
        int to = int.Parse(args[2]);
        Subject subject = subjects[subjectName];
        var lessons = subject.GetLessonsBetweenDuration(from, to);
        if (!lessons.Any()) return string.Empty;
        return string.Join(Environment.NewLine + Environment.NewLine, lessons.Select(l => l.ToString()));
    }
}