using System;

namespace P08PetShop
{
    internal class Program
    {
        static void Main()
        {
            //Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.
            //Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв,
            //а опаковка храна за котки струва 4 лв.
            
            
            int packageofdogsfood=int.Parse(Console.ReadLine());

            int packageofcatfood=int.Parse(Console.ReadLine());

            double totalpricedogfood=packageofdogsfood*2.50;

            double totalpricecatfood = packageofcatfood*4;

            double totalpriceforboth = totalpricecatfood + totalpricedogfood;

            Console.WriteLine($"{totalpriceforboth} lv.");
            
           





            
        }
    }
}
