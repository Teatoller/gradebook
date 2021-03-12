using System;
using System.Collections.Generic;

namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public interface IBook
    {
        void AddGrade(double grade);

        Statistics GetStatistics();

        string Name { get; }

        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NameObject, IBook
    {
        protected Book(string name) :
            base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }

    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) :
            base(name)
        {
            grades = new List<double>();
            this.Name = name;
        }

        public void AddLetterGrade(char Letter)
        {
            switch (Letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add (grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            for (var index = 0; index < grades.Count; index += 1)
            {
                result.Add(grades[index]);
            }

            return result;
        }

        private List<double> grades;
    }
}
