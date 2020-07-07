using System;
using System.Collections.Generic;

namespace Gradebook
{
      class Book
    {

        // constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade( double grade )
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
        
            Console.WriteLine($"The aveage is: {result}\n High is: {highGrade}\n the Low is: {lowGrade}"); 

        }
        private List<double> grades;
        private string name;
    }

}