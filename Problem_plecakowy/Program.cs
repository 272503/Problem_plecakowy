using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Problem_plecakowy;
[assembly: InternalsVisibleTo("Plecak_Test"), InternalsVisibleTo("Aplikacja")]
namespace Problem_plecakowy { }

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of items: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter seed: ");
        int seed = int.Parse(Console.ReadLine());
        Console.Write("Enter knapsack capacity: ");
        int capacity = int.Parse(Console.ReadLine());

        Problem problem = new Problem(n, seed);
        Console.WriteLine("Generated Items:");
        Console.WriteLine(problem);

        Result result = problem.Solve(capacity);
        Console.WriteLine("Solution:");
        Console.WriteLine(result);

    }
}

