using System;

namespace P02Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            double TerezasMoneyPerDay = double.Parse(Console.ReadLine());
            double salaryforaday = double.Parse(Console.ReadLine());
            double costsForallDays = double.Parse(Console.ReadLine());
            double pricePresent = double.Parse(Console.ReadLine());

            double moneyforallDays = TerezasMoneyPerDay * 5;
            double salaryforalldays = salaryforaday * 5;
            double totalraiseMoney = (moneyforallDays + salaryforalldays)-costsForallDays;

            if(totalraiseMoney>=pricePresent)
            {
                Console.WriteLine($"Profit: {totalraiseMoney:f2} BGN, the gift has been purchased.");
            }

             else
            {
                double insufficientMoney = pricePresent - totalraiseMoney;
                Console.WriteLine($"Insufficient money: {insufficientMoney:f2} BGN.");
            }

        }
    }
}
