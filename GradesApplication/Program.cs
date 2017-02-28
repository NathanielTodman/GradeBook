using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeBook book = CreateBook();
            AddGrades(book);
            WriteStatistics(book);
            SaveGrades(book);
        }

        private static void SaveGrades(IGradeBook book)
        {
            using (StreamWriter file = File.CreateText($"{book.Name}-grades.txt"))
            {
                book.WriteGrades(file);
            }
        }

        private static IGradeBook CreateBook()
        {
            IGradeBook book = new GradeBook();
            do
            {
                Console.WriteLine("Please enter a name for your new book:");
                book.Name = Console.ReadLine();
            } while (string.IsNullOrEmpty(book.Name));
            return book;
        }

        private static void WriteStatistics(IGradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Average", stats.AverageGrade);
            Console.WriteLine($"Your overall letter grade is {stats.LetterGrade}");
        }

        private static void WriteResult(string description, float grade)
        {
            Console.WriteLine($"{description}: {grade}"); ;
        }

        private static void AddGrades(IGradeBook book)
        {
            book.AddGrade(92);
            book.AddGrade(93.4f);
            book.AddGrade(89.3f);
            book.AddGrade(78.7f);
        }
        
    }
}
