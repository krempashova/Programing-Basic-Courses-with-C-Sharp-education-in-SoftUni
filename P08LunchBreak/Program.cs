using System;

namespace P08LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

             string titelSerial=Console.ReadLine();

             int episodDuration= int.Parse(Console.ReadLine());

            int breakDuration=int.Parse(Console.ReadLine());

            double lunchBreak = breakDuration / 8.0;
            double doNotnihg = breakDuration / 4.0;

            double timeforepisod = breakDuration - lunchBreak - doNotnihg;
            if(timeforepisod>=episodDuration)
            {
                double timeleft =Math.Ceiling( timeforepisod - episodDuration);
                Console.WriteLine($"You have enough time to watch {titelSerial} and left with {timeleft} minutes free time.");
            }
                 

            else
            {
                double timeneeded =Math.Ceiling( episodDuration - timeforepisod);
                Console.WriteLine($"You don't have enough time to watch {titelSerial}, you need {timeneeded} more minutes.");
            }




        }
    }
}
