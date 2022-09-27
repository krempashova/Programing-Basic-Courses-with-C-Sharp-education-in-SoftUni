using System;

namespace P09Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Първи ред - дни за престой - цяло число в интервала [0...365]

            //Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"

            //Трети ред -оценка - "positive" или "negative"

            int daysvacantion = int.Parse(Console.ReadLine());

            string typeOFRoom=Console.ReadLine();
             
            string feedback=Console.ReadLine();
            double priceroomfornight = 0;
            double priceapartmentfornight = 0;
            double pricepresidentapartmentfornight=0;
            double totalpricevacantion = 0;
            double totalnightToPay = daysvacantion - 1;
            double discount = 0;
            //"room for one person" – 18.00 лв за нощувка
            //"//apartment" – 25.00 лв за нощувка//
            //"president apartment" – 35.00 лв за нощувка

            if (typeOFRoom == "room for one person")
            {
                priceroomfornight = 18.00;
                totalpricevacantion = priceroomfornight * totalnightToPay;
            }
            else if (typeOFRoom == "apartment")
            {
                priceapartmentfornight = 25.00;
                totalpricevacantion = priceapartmentfornight * totalnightToPay;
                if (daysvacantion < 10)
                {
                    discount = 0.30 * totalpricevacantion;
                    totalpricevacantion -= discount;
                }
                else if (daysvacantion >= 10 && daysvacantion <= 15)
                {
                    discount = 0.35 * totalpricevacantion;
                    totalpricevacantion -= discount;
                }
                else if (daysvacantion > 15)
                {
                    discount = 0.50 * totalpricevacantion;
                    totalpricevacantion -= discount;
                }
            }

            else if(typeOFRoom== "president apartment")
            {
                pricepresidentapartmentfornight = 35.00;
                totalpricevacantion = pricepresidentapartmentfornight * totalnightToPay;
                if(daysvacantion<10)
                {
                    discount = 0.10 * totalpricevacantion;
                    totalpricevacantion -= discount;
                }
                else if(daysvacantion>=10 && daysvacantion<=15)
                {
                    discount = 0.15 * totalpricevacantion;
                    totalpricevacantion -= discount;
                }
                else if(daysvacantion>15)
                {
                    discount = 0.20 * totalpricevacantion;
                    totalpricevacantion -= discount;
                }
            }

            if(feedback== "positive")
            {
                totalpricevacantion = totalpricevacantion + (0.25 * totalpricevacantion);
            }
            else if(feedback== "negative")
            {
                totalpricevacantion = totalpricevacantion - (0.10 * totalpricevacantion);
            }
            Console.WriteLine($"{totalpricevacantion:f2}");
        }
    }
}
