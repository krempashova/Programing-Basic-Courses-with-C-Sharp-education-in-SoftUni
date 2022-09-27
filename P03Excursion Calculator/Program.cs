using System;

namespace P03Excursion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int numPeopeForExcursion = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double priceforaperson = 0;
            double discountSummer = 0;
            double incrieseWinter = 0;
            double totalPriceForExcursion = 0;
            
            if(numPeopeForExcursion>0&& numPeopeForExcursion<=5)
            {
                if(season== "spring")
                {
                    
                    totalPriceForExcursion = numPeopeForExcursion * 50;
                    

                }
                else if(season== "summer")
                {
                    totalPriceForExcursion = numPeopeForExcursion * 48.50;
                    discountSummer = totalPriceForExcursion * 0.15;
                    totalPriceForExcursion -= discountSummer;
                }
                else if(season== "autumn")
                {
                    totalPriceForExcursion = numPeopeForExcursion * 60.00;
                }
                        
                else
                {
                    totalPriceForExcursion = numPeopeForExcursion * 86.00;
                    incrieseWinter = totalPriceForExcursion * 0.08;
                    totalPriceForExcursion += incrieseWinter;
                }
            }
            else if(numPeopeForExcursion>5)
            {

                if (season == "spring")
                {
                    totalPriceForExcursion = numPeopeForExcursion * 48.00;
                  
                }
                else if (season == "summer")
                {
                    totalPriceForExcursion = numPeopeForExcursion * 45.00;

                    discountSummer = totalPriceForExcursion * 0.15;
                    totalPriceForExcursion -= discountSummer;
                }
                else if (season == "autumn")
                {
                    totalPriceForExcursion = numPeopeForExcursion * 49.50;
                  
                }

                else
                {
                    totalPriceForExcursion = numPeopeForExcursion * 85.00;

                    incrieseWinter = totalPriceForExcursion * 0.08;
                    totalPriceForExcursion += incrieseWinter;
                }
                

            }
          
            
            
            Console.WriteLine($"{totalPriceForExcursion:f2} leva.");
            
        }
    }
}
