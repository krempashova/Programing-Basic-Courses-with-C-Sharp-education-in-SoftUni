using System;

namespace P02Exam_PreparationWHILEEX
{
    internal class Program 


        static void Main(string[] args)
        { 
           
        int BadresolvedTasks = int.Parse(Console.ReadLine());

               string nameTask = "";

               double totalsumOfGrades = 0;
                 int conterGoodgrades = 0;
                  int conterBadGrades = 0;
                 string Lastproblem = "";

              while(nameTask!= "Enough")
            {
                 nameTask = Console.ReadLine();
                 int grade = int.Parse(Console.ReadLine());

                if(grade>4)
                {
                totalsumOfGrades += grade;
                conterGoodgrades++;
                
                }
                else
               {
                totalsumOfGrades += grade;
                conterBadGrades++;

                Lastproblem = nameTask;
               }
                if(conterBadGrades >= BadresolvedTasks)
            {
                break;
            }

            }
            double totalproblems = conterBadGrades + (double)conterGoodgrades;
              if(nameTask=="Enough")
        {
            double averagescore = totalsumOfGrades / conterGoodgrades;
            Console.WriteLine($"Average score: { averagescore:f2}");
            
            Console.WriteLine($"Number of problems: {totalproblems}");
            Console.WriteLine($"Last problem: {Lastproblem}");
        }

               if(conterBadGrades>=conterGoodgrades)
        {
            Console.WriteLine($"You need a break, {conterBadGrades} poor grades.");
        }


        }
    }

