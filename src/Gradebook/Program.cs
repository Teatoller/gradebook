using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Steven's Grade Book");

            while (true)
            {
                System.Console.WriteLine("Enter a grade or 'q' to quit");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    double grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

            }

            var stats = book.GetStatistics();
            book.Name = "";

            Console.WriteLine($"Student: {book.Name}");
            Console.WriteLine($"The Highest grade is {stats.High:N2}");
            Console.WriteLine($"The Lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The Average grade is {stats.Average:N2}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");
            Console.WriteLine("**");

        }
    }
}
