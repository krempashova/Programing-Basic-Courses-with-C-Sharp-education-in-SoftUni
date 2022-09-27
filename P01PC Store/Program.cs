using System;

namespace P01PC_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            double pricessorProceInDollars = double.Parse(Console.ReadLine());
           double priceVideocardDollars = double.Parse(Console.ReadLine());
            double priceforOneRAMinDollars = double.Parse(Console.ReadLine());
            int numRam = int.Parse(Console.ReadLine());
            double procenticediscount = double.Parse(Console.ReadLine());

            double priceprocessorLV=pricessorProceInDollars*1.57;

            double priceVideocardLV = priceVideocardDollars * 1.57;
            double priceForOneRAMLV = priceforOneRAMinDollars * 1.57;
            double totalpriceRamLV = priceForOneRAMLV * numRam;

            double discountProcessor = priceprocessorLV - (priceprocessorLV * procenticediscount);
           double discountVideoCard = priceVideocardLV - (priceVideocardLV * procenticediscount);
           double totalToPay = discountProcessor + discountVideoCard + totalpriceRamLV;


            Console.WriteLine($"Money needed - {totalToPay:f2} leva.");


        }
    }
}
