using System;

namespace P05GodzilaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moviebudget = double.Parse(Console.ReadLine());

            int numberofextras = int.Parse(Console.ReadLine());

            double priceclothesforonesxtras = double.Parse(Console.ReadLine());

            double decor = moviebudget * 0.1;
            double coastforoneextras = numberofextras * priceclothesforonesxtras;

            double coast = coastforoneextras + decor;

            if(numberofextras>150)
            {
                coast = (coastforoneextras - (coastforoneextras * 0.1)) + decor;

            }
            if (coast>moviebudget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {coast - moviebudget:f2} leva more.");
             

            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with { moviebudget - coast:f2} leva left." );
            }




        }
    }
}
