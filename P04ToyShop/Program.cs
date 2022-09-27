using System;

namespace P04ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceexcursion=double.Parse(Console.ReadLine());
            int puzels=int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //Цени на играчките:
            //Пъзел - 2.60 лв.
            ///Говореща кукла -3 лв.
            //Плюшено мече -4.10 лв.
            //Миньон - 8.20 лв.
            //	Камионче - 2 лв.

            double totalpuzels = puzels * 2.60;
            double totaldolls = dolls * 3;
            double totalbears = bears * 4.10;
            double totalminions = minions    * 8.20;
            double totaltruks = trucks * 2;
            double turnover = totalpuzels + totaldolls + totalbears + totalminions + totaltruks;
            int gamenumber = puzels + dolls + bears + minions + trucks;
            

            if(gamenumber>=50)
                {
                turnover = turnover - (turnover / 4);
            }

            double rentshop = turnover * 0.1;
            double totalturnover = turnover - rentshop;

            if (totalturnover >= priceexcursion)

            {
                totalturnover = totalturnover - priceexcursion;
                
                
                 Console.WriteLine($"Yes! {totalturnover:f2} lv left.");
             
            }

            else
            {
                totalturnover = priceexcursion - totalturnover;
               
                    Console.WriteLine($"Not enough money! {totalturnover:f2} lv needed.");
            }
            

           
         







        }
    }
}
