using System;

namespace P05Coinswhileex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cnahge = decimal.Parse(Console.ReadLine());

            int coinCounter = 0;

            while (cnahge > 0.00m)
            {
                if (cnahge >= 2m)
                {
                    cnahge -= 2.0m;
                    coinCounter++;
                }
                else if (cnahge >= 1.0m)
                {
                    cnahge -= 1m;
                    coinCounter++;
                }
                else if (cnahge >= 0.5m)
                {
                    cnahge -= 0.5m;
                    coinCounter++;
                }
                else if (cnahge >= 0.2m)
                {
                    cnahge -= 0.2m;
                    coinCounter++;
                }
                else if (cnahge >= 0.1m)
                {
                    cnahge -= 0.1m;
                    coinCounter++;
                }
                else if (cnahge >= 0.05m)
                {
                    cnahge -= 0.05m;
                    coinCounter++;
                }
                else if (cnahge >= 0.02m)
                {
                    cnahge -= 0.02m;
                    coinCounter++;
                }
                else if (cnahge >= 0.01m)
                {
                    cnahge -= 0.01m;
                    coinCounter++;
                }

            }
            Console.WriteLine(coinCounter);





        }
    }
}
