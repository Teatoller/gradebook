using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Steven's Grade Book");
            book.AddGrade(88.4);
            book.AddGrade(90.6);
            book.AddGrade(75.2);

            var stats = book.GetStatistics();

            // Console.WriteLine($"Student: {name}");
            Console.WriteLine($"The Highest grade is {stats.High:N2}");
            Console.WriteLine($"The Lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The Average grade is {stats.Average:N2}");

        }
    }
}
