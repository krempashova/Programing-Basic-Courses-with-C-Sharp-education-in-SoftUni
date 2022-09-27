using System;

namespace P06FoodDelivery
{
    internal class Program
    {
        static void Main()
        {
           int numberchickenmenu = int.Parse(Console.ReadLine());
            int numberfishmenu=int.Parse(Console.ReadLine());
            int numberveganmenu = int.Parse(Console.ReadLine());
            
            double pricechikenmenu = numberchickenmenu * 10.35;
            double pricefishmenu = numberfishmenu * 12.40;
            double priceveganmenu = numberveganmenu * 8.15;
            double totalpricefoodwodesert = pricechikenmenu + pricefishmenu + priceveganmenu;



            double pricedesert = totalpricefoodwodesert * 0.20;
            double totalpricewithdelivery = totalpricefoodwodesert + pricedesert + 2.50;
            Console.WriteLine(totalpricewithdelivery);



        }
    }
}
