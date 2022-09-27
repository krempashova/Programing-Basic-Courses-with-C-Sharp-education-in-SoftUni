using System;

namespace P07Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocard=int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double videocardprice = videocard * 250;
            double procesorSingleprice = 0.35 * videocardprice;
            double totalforprocesors = procesors * procesorSingleprice;
            double ramsingleprice = 0.1 * videocardprice;
            double totalforram=ram* ramsingleprice;

            double totalForAll = videocardprice + totalforprocesors + totalforram;

            if (videocard > procesors)
            {
                double discound = 0.15 * totalForAll;
                totalForAll -= discound;
            }
                if(budget>=totalForAll)
                {
                    double momeyremainig = budget - totalForAll;
                    Console.WriteLine($"You have {momeyremainig:f2} leva left!");
                }

            else
            {
                double insuficient = totalForAll - budget;
                Console.WriteLine($"Not enough money! You need {insuficient:f2} leva more!");
            }

            
                





        }
    }
}
