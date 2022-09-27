using System;

namespace P03Time15seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour=int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int fifteenMinutes = 15;
             minutes = minutes + fifteenMinutes;
            
            if(minutes>59)
            {
                hour = hour + 1;
                if(hour>23)
                  {
                    hour = 0;
                }
                minutes = minutes - 60;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
