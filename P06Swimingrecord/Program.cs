using System;

namespace P06Swimingrecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordinSeconds=double.Parse(Console.ReadLine());
            double distanceinMeters=double.Parse(Console.ReadLine());
            double timeinsocondspermeter = double.Parse(Console.ReadLine());
            double timefordistance = distanceinMeters * timeinsocondspermeter;
            double timeDelay = Math.Floor(distanceinMeters / 15);
            double delaytime = timeDelay * 12.5;
            double totaltime = timefordistance + delaytime;
            if(totaltime<recordinSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is { totaltime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totaltime -recordinSeconds:f2} seconds slower.");
            }

        }
    }
}78
