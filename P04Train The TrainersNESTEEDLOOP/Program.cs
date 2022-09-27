using System;

namespace P04Train_The_TrainersNESTEEDLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalGradeforCourse = 0;
            int presentationCounter = 0;
            int numJury = int.Parse(Console.ReadLine());
            string input = "";    

            while(true)

            {
                 input = Console.ReadLine();
                if (input=="Finish")
                {
                    break;
                }

                string presentationName=input;
                presentationCounter++;

                double totalGradeforpresentation = 0;
                for (int i=1;i<=numJury;i++)
                {
                  double gradeForpresentation=double.Parse(Console.ReadLine());
                    
                   totalGradeforpresentation += gradeForpresentation;   

                }
                 double averageForPresentation=totalGradeforpresentation/numJury;
                    totalGradeforCourse += averageForPresentation;

                Console.WriteLine($"{presentationName} - {averageForPresentation:f2}.");


            }

            double averageForCourse = totalGradeforCourse / presentationCounter;

                Console.WriteLine($"Student's final assessment is {averageForCourse:f2}.");


            



        }
    }
}
