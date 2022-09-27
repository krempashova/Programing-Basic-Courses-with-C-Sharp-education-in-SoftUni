using System;

namespace P08Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string name=Console.ReadLine();
            int counternumberclass = 1;
            double averagegrade = 0;
            int counter = 0;
           double totalgrade = 0;
           
            while(counternumberclass<=12)
            {
                 double yearGrade =double.Parse(Console.ReadLine());
                if (yearGrade>=4)
                {
                    
                    totalgrade+=yearGrade;
                    counternumberclass++;
                    continue;
                }
                if(yearGrade<4)
                {
                    counter++;
                }
                if(counter>1)
                {
                    break;
                }
            }
            if(counter>1)
            {
                Console.WriteLine($"{name} has been excluded at {counternumberclass} grade");
            }
       else
            {
                averagegrade = totalgrade /(double) (counternumberclass-1);
                Console.WriteLine($"{name} graduated. Average grade: {averagegrade:f2}");
            }







        }
    }
}
