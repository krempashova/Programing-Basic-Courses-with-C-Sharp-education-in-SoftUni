using System;

namespace P04Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availableBudget = int.Parse(Console.ReadLine());

            string season=Console.ReadLine();

            int numFisherman = int.Parse(Console.ReadLine());

            
            double shipRentalPrice = 0;
            double discount = 0;
             
            switch (season)
            {
                case"Spring":
                    shipRentalPrice = 3000;
                    if(numFisherman<=6)
                    {
                        discount = 0.1 * shipRentalPrice;
                    }
                    else if(numFisherman>=7 && numFisherman<=11)
                    {
                        discount = 0.15 * shipRentalPrice;
                    }
                    else if(numFisherman>12)
                    {
                        discount = 0.25 * shipRentalPrice;
                    }
                            
                    break;
                case "Summer":
                case "Autumn":

                    shipRentalPrice = 4200;
                    if (numFisherman <= 6)
                    {
                        discount = 0.1 * shipRentalPrice;
                    }
                    else if (numFisherman >= 7 && numFisherman <= 11)
                    {
                        discount = 0.15 * shipRentalPrice;
                    }
                    else if (numFisherman > 12)
                    {
                        discount = 0.25 * shipRentalPrice;
                    }
                    break;
                case"Winter":
                    shipRentalPrice = 2600;
                    if (numFisherman <= 6)
                    {
                        discount = 0.1 * shipRentalPrice;
                    }
                    else if (numFisherman >= 7 && numFisherman <= 11)
                    {
                        discount = 0.15 * shipRentalPrice;
                    }
                    else if (numFisherman > 12)
                    {
                        discount = 0.25 * shipRentalPrice;
                    }
                    break;

            }
                         shipRentalPrice -= discount;

            bool isFishermanisEven = (numFisherman % 2 == 0 && season != "Autumn");

            if(isFishermanisEven&&season!= "Autumn")
            {
                shipRentalPrice -= 0.05* shipRentalPrice;
            }
            if(availableBudget>=shipRentalPrice)
            {
                double moneyleft = availableBudget - shipRentalPrice;
                Console.WriteLine($"Yes! You have {moneyleft:f2} leva left.");
            }
            else
            {
                double inssufision = shipRentalPrice - availableBudget;
                Console.WriteLine($"Not enough money! You need {inssufision:f2} leva.");
            }



        }
    }
}
