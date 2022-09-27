using System;

namespace P09FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();

            string dayOfWeek=Console.ReadLine();


            double quantity = double.Parse(Console.ReadLine());
            double fruitPrice = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    fruitPrice = 2.50;
                }
                else if (fruit == "apple")
                {
                    fruitPrice = 1.20;
                }
                else if (fruit == "orange")
                {
                    fruitPrice = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    fruitPrice = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    fruitPrice = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    fruitPrice = 5.50;
                }
                else if (fruit == "grapes")
                {
                    fruitPrice = 3.85;
                }

            }

            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    fruitPrice = 2.70;
                }
                else if (fruit == "apple")
                {
                    fruitPrice = 1.25;
                }
                else if (fruit == "orange")
                {
                    fruitPrice = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    fruitPrice = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    fruitPrice = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    fruitPrice = 5.60;
                }
                else if (fruit == "grapes")
                {
                    fruitPrice = 4.20;
                }

            }

     

            
                double totalPrice = quantity * fruitPrice;
            if(totalPrice>0)
            {
                Console.WriteLine($"{totalPrice:F2}");
            }
                else
            {
                Console.WriteLine("error");
            }
            
            

            

            



        }
    }
}
