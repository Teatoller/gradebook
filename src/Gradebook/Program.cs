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
            book.showStatistics();

            var book2 = new Book("Angie's Grade Book");
            book2.AddGrade(87.4);
            book2.AddGrade(90.7);
            book2.AddGrade(73.2);
            book2.showStatistics();

        }
    }
}
