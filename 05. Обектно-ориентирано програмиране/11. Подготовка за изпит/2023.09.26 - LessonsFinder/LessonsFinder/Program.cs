using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Controller controller = new Controller();
        bool isRunning = true;
        while (isRunning)
        {
            string[] splittedInput = Console.ReadLine().Split();

            string command = splittedInput[0];
            List<string> arguments = splittedInput
                .Skip(1)
                .ToList();

            string result = "";
            try
            {
                switch (command)
                {
                    case "AddSubject":
                        result = controller.AddSubject(arguments);
                        break;
                    case "AddLesson":
                        result = controller.AddLesson(arguments);
                        break;
                    case "RateLesson":
                        result = controller.RateLesson(arguments);
                        break;
                    case "GetAverageRating":
                        result = controller.GetAverageRating(arguments);
                        break;
                    case "GetLessonsByTeacher":
                        result = controller.GetLessonsByTeacher(arguments);
                        break;
                    case "GetLessonsBetweenDuration":
                        result = controller.GetLessonsBetweenDuration(arguments);
                        break;
                    case "End":
                        isRunning = false;
                        break;
                    default:
                        result = "Invalid command";
                        break;
                }

                if (!isRunning) { break; }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
