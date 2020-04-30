using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new InMemoryBook("Steven's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();
            book.Name = "";

            Console.WriteLine($"Student: {book.Name}");
            Console.WriteLine($"The Highest grade is {stats.High:N2}");
            Console.WriteLine($"The Lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The Average grade is {stats.Average:N2}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");
        }

        private static void EnterGrades(Book book)
        {
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
                finally
                {
                    System.Console.WriteLine("~~~");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            System.Console.WriteLine("A Grade was Added");
        }
    }
}
