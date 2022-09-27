using System;

namespace P05TravellingNesteedlopp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = "";



            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                destination = input;

                double minbudget = double.Parse(Console.ReadLine());


                while (minbudget > 0)

                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    minbudget -= savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");

                if (input == "End")

                {
                    return;
                }
            }




        }
    }
}
