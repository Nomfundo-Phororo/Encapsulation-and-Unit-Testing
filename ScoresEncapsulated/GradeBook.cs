using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresEncapsulated
{
     public class GradeBook
    {
       public List<double> grades;

        public GradeBook()
        {
            grades = new List<double>();
        }
       
        public void Addgrade(double grade)
        {
            grades.Add(grade);
        }
      
        public Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            if (grades.Count!=0)
            {
                
                statistics.Average = Math.Round(grades.Average(), 1);
                statistics.Highgrade = grades.Max();
                statistics.Lowgrade = grades.Min();

                return statistics;
            }
            else
            {
                statistics.Average = 0;
                statistics.Highgrade = 0;
                statistics.Lowgrade = 0;
                return statistics;
            }
         
        }
        public  void GetUserStatistics(Statistics result)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The average is: {0}", Math.Round(result.Average, 2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The highest is: {0}", Math.Round(result.Highgrade, 2));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The lowest grade is: {0}", Math.Round(result.Lowgrade, 2));
        }

        public void Greetings()
        {
            Console.Write("Enter students name:");
            string name = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                           Welcome {0}", name, Environment.NewLine);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------RULES----------------------------------------------");
            Console.WriteLine("1.Enter decimal numbers", Environment.NewLine);
            Console.WriteLine("2.Scores must be less that 100 ");
            Console.WriteLine("3.To stop entering scores and see stats, enter '111' ");
        }

        public int UserAddingGrades(GradeBook gradeBook, int i)
        {
            do
            {

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" Please enter score {0}", i);

                string answer = Console.ReadLine();

                double score;

                bool success = double.TryParse(answer, out score);




                if (success)
                {
                    if (score == 111)
                    {
                        break;
                    }
                    else if (score <= 100 && score > -1)
                    {
                        gradeBook.Addgrade(score);
                        i++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Must be less than 100 and greater than 0");
                        continue;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!! Score must be a Decimal........ You were warned :(");
                    continue;
                }


            }
            while (!gradeBook.grades.Contains(111));
            return i;
        }

    }
}
