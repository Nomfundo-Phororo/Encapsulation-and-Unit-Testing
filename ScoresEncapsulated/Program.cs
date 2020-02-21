using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresEncapsulated
{
    class Program
    {
        static void Main(string[] args)

        {


            GradeBook gradeBook = new GradeBook();
            gradeBook.Greetings();

            int i = 1;

            i = gradeBook.UserAddingGrades(gradeBook, i);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            var result = gradeBook.GetStatistics();
            gradeBook.grades.ForEach(a => Console.Write("{0},", a));

            Console.WriteLine("");
            gradeBook.GetUserStatistics(gradeBook.GetStatistics());

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Press any key to leave...");
            Console.ReadKey();

        }

    }
}
