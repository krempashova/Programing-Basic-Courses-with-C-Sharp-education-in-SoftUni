using System;

namespace P04Walking_WHILEEX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalsteps = 0;
            string input = "";


            while(input!= "Going home" && totalsteps<10000)
            {
                input = Console.ReadLine();
                if(input=="Going home")
                {
                    int stepstoHome = int.Parse(Console.ReadLine());
                    totalsteps += stepstoHome;
                    break;
                }
                int steps = int.Parse(input);
                totalsteps += steps;
                if(totalsteps<10000)
                {
                    continue;
                }    
                else
                {
                    break;
                }
            }
            if (totalsteps >= 10000)
            {
                int stepsOverTotal = totalsteps - 10000;
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsOverTotal} steps over the goal!");
            }

            else if (totalsteps < 10000)
            {
                int insuficualSteps = 10000 - totalsteps;
                Console.WriteLine($"{insuficualSteps} more steps to reach goal.");
            }





        }
    }
}
