using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> grades = new List<double>() { 14.2, 15.8, 64.0, 10 };

            grades.Add(65.0);
            grades.Add(95.0);
            grades.Add(85.0);

            double result = 0;


            foreach (double grade in grades)
            {
                result += grade;
            }

            result /= grades.Count;

            Console.WriteLine($"The Average grade is {result:N2}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
