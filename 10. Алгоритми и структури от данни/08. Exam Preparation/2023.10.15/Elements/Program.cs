﻿using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    private static IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> elements, int a)
    {
        return a == 0 ? new[] { new T[0] } : elements.SelectMany((x, y) => Combinations(elements.Skip(y + 1), a - 1).Select(c => (new[] { x }).Concat(c)));
    }

    public static void Main()
    {
        List<string> elementsList = Console.ReadLine().Split().ToList();
        int N = int.Parse(Console.ReadLine());
        List<string> priorityElements = Console.ReadLine().Split().ToList();

        List<List<string>> experiments = new List<List<string>>();
        var combinations = Combinations(elementsList, N);

        foreach (var combo in combinations)
        {
            List<string> experiment = combo.ToList();

            bool hasPriority = priorityElements.Any(experiment.Contains);

            if (hasPriority)
            {
                experiment = experiment.OrderBy(e => priorityElements.IndexOf(e) < 0 ? int.MaxValue : priorityElements.IndexOf(e)).ToList();
            }

            experiments.Add(experiment);
        }

        foreach (var experiment in experiments)
        {
            Console.WriteLine(string.Join(" ", experiment));
        }
    }
}