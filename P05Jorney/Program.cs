using System;

namespace P05Jorney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal availableBudget = decimal.Parse(Console.ReadLine());

            string season = Console.ReadLine();
             string destination="";
           decimal totalTopay = 0m;
            string placeforvacation = "";
            if (availableBudget <= 100)
            {
                destination = "Somewhere in Bulgaria";
                if (season == "summer")
                {
                    totalTopay = 0.30m * availableBudget;
                    placeforvacation = "Camp";
                }
                else if (season == "winter")
                {
                    totalTopay = 0.7m * availableBudget;
                    placeforvacation = "Hotel";
                }
            }
            else if (availableBudget <= 1000)
            {
                destination = "Somewhere in Balkans";
                if (season == "summer")
                {
                    totalTopay = 0.40m * availableBudget;
                    placeforvacation = "Camp";
                }
                else if (season == "winter")
                {
                    totalTopay = 0.8m * availableBudget;
                    placeforvacation = "Hotel";
                }
            }
            else if (availableBudget > 1000)
            {
                destination = "Somewhere in Europe";

                totalTopay = 0.9m * availableBudget;
                placeforvacation = "Hotel";
            }
            

            Console.WriteLine($"{destination}");

            Console.WriteLine($"{placeforvacation} - {totalTopay:f2}");
        }
    }
}
