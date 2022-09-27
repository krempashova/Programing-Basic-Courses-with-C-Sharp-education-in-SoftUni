using System;

namespace P03NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string flowerType = Console.ReadLine();

            int flowerNum = int.Parse(Console.ReadLine());

            int availableBudget = int.Parse(Console.ReadLine());

            double totalToPay = 0;
            double discount = 0;

            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //5             3.80      2.80      3          2.50
            if (flowerType == "Roses")
            {
                totalToPay = flowerNum * 5;
                if (flowerNum > 80)
                {
                    discount = 0.1 * totalToPay;
                    totalToPay -= discount;

                }

            }



            else if (flowerType == "Dahlias")
            {
                totalToPay = flowerNum * 3.8;
                if (flowerNum > 90)
                {
                    discount = 0.15 * totalToPay;
                    totalToPay -= discount;
                }
            }
                
            
            else if (flowerType == "Tulips")
            {
                totalToPay = flowerNum * 2.8;
                if (flowerNum > 80)
                {
                    discount = 0.15 * totalToPay;
                    totalToPay -= discount;
                }
            }
               
            else if (flowerType == "Narcissus")
            {
                totalToPay = flowerNum * 3;
                if (flowerNum < 120)
                {
                    discount = 0.15 * totalToPay;
                    totalToPay += discount;
                }
            } 
               

            else if(flowerType== "Gladiolus")
            {
                totalToPay = flowerNum * 2.5;
                if (flowerNum < 80)
                {
                    discount = 0.20 * totalToPay;
                    totalToPay += discount;

                }
            }
               if(availableBudget>=totalToPay)
            {
                double moneyleft = availableBudget - totalToPay;
                Console.WriteLine($"Hey, you have a great garden with {flowerNum} {flowerType} and {moneyleft:f2} leva left.");
            }
                
               else
            {
                double lackOfMoney = totalToPay - availableBudget;
                Console.WriteLine($"Not enough money, you need {lackOfMoney:f2} leva more.");
            }




        }
    }
}
