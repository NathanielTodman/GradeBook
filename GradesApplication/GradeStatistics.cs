namespace GradesApplication
{
    public class GradeStatistics
    {
        public float HighestGrade = float.MinValue;
        public float LowestGrade = float.MaxValue;
        public float AverageGrade;
        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                    result = "F";
                return result;
            }
        }
    }
}