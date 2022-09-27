using System;

namespace P05SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string product=Console.ReadLine();

            string city=Console.ReadLine();


            double quantity=double.Parse(Console.ReadLine());

            decimal produtPrice = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    produtPrice = 0.50m;
                }
                else if (product == "water")
                {
                    produtPrice = 0.80m;
                }
                else if (product == "beer")
                {
                    produtPrice = 1.20m;
                }
                else if (product == "sweets")
                {
                    produtPrice = 1.45m;
                }

                else if (product == "peanuts")
                {
                    produtPrice = 1.60m;
                }
            }

            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    produtPrice = 0.40m;
                }
                else if (product == "water")
                {
                    produtPrice = 0.70m;
                }
                else if (product == "beer")
                {
                    produtPrice = 1.15m;
                }
                else if (product == "sweets")
                {
                    produtPrice = 1.30m;
                }
                else if (product == "peanuts")
                {
                    produtPrice = 1.50m;
                }



            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    produtPrice = 0.45m;
                }

                else if (product == "water")
                {
                    produtPrice = 0.70m;
                }
                else if (product == "beer")
                {
                    produtPrice = 1.10m;
                }
                else if (product == "sweets")
                {
                    produtPrice = 1.35m;
                }
                else if (product == "peanuts")
                {
                    produtPrice = 1.55m;
                }

            }

          decimal totalPrice =(decimal)quantity * produtPrice;
            Console.WriteLine(totalPrice);
        }




    }
}
