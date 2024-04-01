namespace Code
{
    public class StudentGrader
    {
        public string StudentRate(double score)
        {
            if (score >= 0 && score <= 40)
            {
                return "F";
            }
            else if (score >= 41 && score <= 60)
            {
                return "D";
            }
            else if (score >= 61 && score <= 70)
            {
                return "C";
            }
            else if (score >= 71 && score <= 80)
            {
                return "B";
            }
            else if (score >= 81 && score <= 100)
            {
                return "A";
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
