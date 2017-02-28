using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    public interface IGradeBook : IEnumerable
    {
        string Name { get; set; }
        GradeStatistics ComputeStatistics();
        void AddGrade(float grade);
        void WriteGrades(TextWriter destination);
    }
}
