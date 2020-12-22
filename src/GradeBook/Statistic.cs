namespace GradeBook
{
    public class Statistic
    {
        public double Average;

        public double HighGrade;

        public double LowGrade;

        public Statistic()
        {
            HighGrade = double.MinValue;
            LowGrade = double.MaxValue;
        }
    }
}
