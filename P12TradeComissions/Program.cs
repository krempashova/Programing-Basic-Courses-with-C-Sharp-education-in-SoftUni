using System;

namespace P12TradeComissions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string city = Console.ReadLine();

            double salesVolume = double.Parse(Console.ReadLine());

            double commision = 0;

            if (city == "Sofia")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commision = salesVolume * 0.05;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commision = salesVolume * 0.07;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commision = salesVolume * 0.08;
                }
                else if (salesVolume > 10000)
                {
                    commision = salesVolume * 0.12;
                }

            }
        else if (city=="Varna")
            {
                if(salesVolume>=0 && salesVolume<=500)
                {
                    commision = salesVolume * 0.045;
                }
                else if(salesVolume>500 && salesVolume<=1000)
                {
                    commision = salesVolume * 0.075;
                }
                else if(salesVolume>1000 && salesVolume<=10000)
                {
                    commision = salesVolume * 0.1;
                }
                else if(salesVolume>10000)
                {
                    commision = salesVolume * 0.13;
                }
            }
            else if(city=="Plovdiv")
            {
                if(salesVolume>=0 && salesVolume<=500)
                {
                    commision = salesVolume * 0.055;
                }
                else if (salesVolume>500 && salesVolume<=1000)
                {
                    commision = salesVolume * 0.08;
                }
                else if (salesVolume>1000 && salesVolume<=10000)
                {
                    commision = salesVolume * 0.12;
                }
                    else if (salesVolume>10000)
                {
                    commision = salesVolume * 0.145;
                }
            }

            if(commision>0)
            {
                Console.WriteLine($"{commision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }





        }
    }
}
