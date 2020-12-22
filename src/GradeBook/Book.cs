
using System.Collections.Generic;
using System;

namespace GradeBook 
{

    public class Book
    {

        private List<double> grades;
        public string Name;

        public string getName() {
            return Name;
        }

        public Book(string name) {
            this.grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade) 
        {
            if (grade <= 100 && grade >= 0)
            {
                this.grades.Add(grade);
            }
        }

        public void AddGradeList(IList<double> list) {
            if (list.Count > 0) {
                foreach(var g in list) {
                   this.AddGrade(g);
                }
            }
        }

        
        public Statistic CalculateStatistic()
        {
            var stats = new Statistic();
            var total = 0.0;

            foreach(var grade in grades)
            {
                stats.HighGrade = Math.Max(stats.HighGrade, grade);
                stats.LowGrade = Math.Min(stats.LowGrade, grade);
                total += grade;
            }

            stats.Average = total / grades.Count;
            return stats;
        }

        public void DisplayStatistic()
        {
            var stats = CalculateStatistic();

            Console.WriteLine($"The Higest grade : {stats.HighGrade}");
            Console.WriteLine($"The Lowest grade is: {stats.LowGrade}");
            Console.WriteLine($"The average grade is: {stats.Average:N}");
        }

    }
}