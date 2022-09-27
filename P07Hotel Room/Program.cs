using System;

namespace P07Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mounth = Console.ReadLine();

            decimal numnights=decimal.Parse(Console.ReadLine());

            decimal priceForNightforapartment = 0m;
            decimal priceForNightforstudio = 0m;
            decimal discountstudio = 0m;
            decimal discountapartment = 0m;
            
            decimal totalTopayForVacationinstudio = 0m;
            decimal totalToPayForVacantionapartment = 0m;

            if (mounth == "May" || mounth == "October")
            {
                priceForNightforstudio = 50m;
                priceForNightforapartment = 65m;
                if (numnights > 7 && numnights < 14)
                {
                    discountstudio = priceForNightforstudio * 0.05m;
                    priceForNightforstudio -= discountstudio;
                }
                else if (numnights > 14)
                {
                    discountstudio = priceForNightforstudio * 0.3m;
                    priceForNightforstudio -= discountstudio;
                    discountapartment = priceForNightforapartment * 0.1m;
                    priceForNightforapartment -= discountapartment;
                }

            }
            else if (mounth == "June" || mounth == "September")
            {
                priceForNightforstudio = 75.20m;
                priceForNightforapartment = 68.70m;
                if (numnights > 14)
                {
                    discountstudio = priceForNightforstudio * 0.2m;
                    priceForNightforstudio -= discountstudio;
                    discountapartment = priceForNightforapartment * 0.1m;
                    priceForNightforapartment -= discountapartment;
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                priceForNightforstudio = 76m;
                priceForNightforapartment = 77m;

                if (numnights > 14)

                {
                    discountapartment = priceForNightforapartment * 0.1m;
                    priceForNightforapartment -= discountapartment;
                }
            }
            totalTopayForVacationinstudio = priceForNightforstudio * numnights;
            totalToPayForVacantionapartment = priceForNightforapartment * numnights;

            Console.WriteLine($"Apartment: {totalToPayForVacantionapartment:f2} lv.");
            Console.WriteLine($"Studio: {totalTopayForVacationinstudio:f2} lv.");



        }
    }
}
