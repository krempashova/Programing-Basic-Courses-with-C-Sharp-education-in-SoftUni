using System;

namespace P06OscarsEX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string actorName = Console.ReadLine();
            double lastYearpoints = double.Parse(Console.ReadLine());
            int juryNameNum = int.Parse(Console.ReadLine());

            double finalpoints = lastYearpoints;

            for (int i = 1; i <= juryNameNum; i++)
            {
                string juryName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                double totalMemberPoint = juryName.Length * points / 2;

                finalpoints += totalMemberPoint;

                if (finalpoints > 1250.5)
                {
                    break;
                }
            }
            if (finalpoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {finalpoints:f1}!");
            }
            else
            {
                double insuficientpoint = 1250.5 - finalpoints;
                Console.WriteLine($"Sorry, {actorName} you need {insuficientpoint:f1} more!");
            }






        }
    }
}
