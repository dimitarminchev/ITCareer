using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Lesson
{
    private string title;
    public string Title
    {
        get => title;
        set
        {
            if (value == null || value.Length < 3 || value.Length > 54)
                throw new ArgumentException("Title should be between 3 and 54 characters!");
            title = value;
        }
    }

    private int duration;
    public int Duration
    {
        get => duration;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Duration should be positive!");
            duration = value;
        }
    }

    private int grade;
    public int Grade
    {
        get => grade;
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentException("Grade should be between 1 and 12!");
            grade = value;
        }
    }

    private int difficulty;
    public int Difficulty
    {
        get => difficulty;
        set
        {
            if (value < 1 || value > 3)
                throw new ArgumentException("Difficulty should be between 1 and 3!");
            difficulty = value;
        }
    }

    private string teacher;
    public string Teacher
    {
        get => teacher;
        set
        {
            if (value == null || value.Length < 3 || value.Length > 54)
                throw new ArgumentException("Teacher should be between 3 and 54 characters!");
            teacher = value;
        }
    }

    private List<int> ratings;
    public IReadOnlyList<int> Ratings => ratings.AsReadOnly();

    public Lesson(string title, int duration, int grade, int difficulty, string teacher)
    {
        this.Title = title;
        this.Duration = duration;
        this.Grade = grade;
        this.Difficulty = difficulty;
        this.Teacher = teacher;
        this.ratings = new List<int>();
    }

    public void AddRating(int rate)
    {
        if (rate < 1 || rate > 5)
            throw new ArgumentException("Rating should be between 1 and 5!");
        ratings.Add(rate);
    }

    public double Rating
    {
        get
        {
            if (!ratings.Any()) return 0.0;
            return ratings.Average();
        }
    }

    public override string ToString()
    {
        return $"Title: {this.Title} for {this.Grade} grade ({this.Duration} mins.) - difficulty {this.Difficulty} by {this.Teacher} (Rating: {this.Rating:F2} / 5)";
    }
}
