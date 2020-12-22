using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ambroise Grade book");
            book.AddGradeList(new List<double> {78.4, 90.9, 60.0});
            book.DisplayStatistic();
        }
    }
}
