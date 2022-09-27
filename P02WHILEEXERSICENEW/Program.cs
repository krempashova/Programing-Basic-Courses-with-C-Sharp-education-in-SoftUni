using System;

namespace P02WHILEEXERSICENEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BadresolvedTasks = int.Parse(Console.ReadLine());

            string nameTask = "";

            double totalsumOfGrades = 0;
            int conterGoodgrades = 0;
            int conterBadGrades = 0;
            string Lastproblem = "";
            

            while ((nameTask=Console.ReadLine()) !="Enough")

            {
                
                int grade = int.Parse(Console.ReadLine());

                if (grade > 4)
                {
                    totalsumOfGrades += grade;
                    conterGoodgrades++;

                }
                else
                {
                    totalsumOfGrades += grade;
                    conterBadGrades++;

                  
                }
                if (conterBadGrades >= BadresolvedTasks)
                {
                    break;
                }
                Lastproblem = nameTask;
            }
           

            double totalproblems = conterBadGrades + (double)conterGoodgrades;
            if (nameTask == "Enough")
            {



                double averagescore = totalsumOfGrades / totalproblems;
                Console.WriteLine($"Average score: { averagescore:f2}");

                Console.WriteLine($"Number of problems: {totalproblems}");
                Console.WriteLine($"Last problem: {Lastproblem}");
            }

             if (conterBadGrades >= BadresolvedTasks)
            {
                Console.WriteLine($"You need a break, {conterBadGrades} poor grades.");
            }
        }
    }
}
