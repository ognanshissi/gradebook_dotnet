using System;
using Xunit;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            // Declarative
            var book = new Book("Ambroise's grade book");
            book.AddGradeList(new List<double>() { 12.8, 19, 17.99 });
            var stats = book.CalculateStatistic();
            Console.WriteLine($"{book.Name}");
            Assert.Equal(12.8, stats.LowGrade);
            Assert.Equal(19, stats.HighGrade);
        }
    }
}
