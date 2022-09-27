using System;

namespace P04Cleverlily

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int LilysAge = int.Parse(Console.ReadLine());

            double machinePrice=double.Parse(Console.ReadLine());

            int singlePriceToy = int.Parse(Console.ReadLine());
            double piggyBank = 0;
            double toysNum = 0;
            int cashGift = 10;


            for( int birthday=1;birthday<=LilysAge;birthday++)
            {
                if(birthday%2==0)
                {

                    piggyBank  += cashGift;
                    piggyBank--;
                    cashGift += cashGift;

                }
                        
                else
                {
                    toysNum++;
                }
                       
                     

            }







        }
    }
}
