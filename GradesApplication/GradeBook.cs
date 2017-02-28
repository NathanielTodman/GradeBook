using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public class GradeBook : IGradeBook
    {
        private string _name;

        protected List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = (float)Math.Round(sum / grades.Count);
            return stats;
        }

        public IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        public void WriteGrades(TextWriter destination)
        {
            foreach(float grade in grades)
            {
                destination.WriteLine(grade);
            }
        }
    }
}
