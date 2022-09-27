using System;

namespace P01Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            //и изчислява общите приходи от билети при пълна зала.
            //Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.

            string type=Console.ReadLine(); 

            int rows=int.Parse(Console.ReadLine());

            int columns=int.Parse(Console.ReadLine());
            double income = 0;
            if(type== "Premiere")
            {
                income = rows * columns * 12;
            }

            else if (type== "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if(type== "Discount")
            {
                income = rows * columns * 5.0;
            }

            Console.WriteLine($"{income:f2} leva");




        }
    }
}
