using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStatistics()
        {
            double result = 0;
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;

            foreach (double grade in grades)
            {
                highGrade = Math.Max(highGrade, grade);
                lowGrade = Math.Min(lowGrade, grade);
                result += grade;
            }

            result /= grades.Count;

            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"The Highest grade is {highGrade:N2}");
            Console.WriteLine($"The Lowest grade is {lowGrade:N2}");
            Console.WriteLine($"The Average grade is {result:N2}");
        }

        private List<double> grades;
        private string name;
    }
}