using System;

namespace P03Vacantion_whileex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double moneyNeedforexcursion = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int dayscounter = 0;
            int spendingcounter = 0;

            while (ownedMoney < moneyNeedforexcursion)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayscounter++;

                if (command == "save")
                {
                    ownedMoney += money;
                    spendingcounter = 0;
                }
                else
                {
                    ownedMoney -= money;
                    spendingcounter++;
                }


                if (spendingcounter == 5)
                {
                    break;
                }

                if (ownedMoney < 0)
                {
                    ownedMoney = 0;
                }
            }

                if (ownedMoney >= moneyNeedforexcursion)
                {
                    Console.WriteLine($"You saved the money for { dayscounter} days.");
                }
            else
            {

                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{dayscounter}");
            }
            
        }
    }
}
