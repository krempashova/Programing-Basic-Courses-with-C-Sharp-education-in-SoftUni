using System;

namespace P04Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numComputers = int.Parse(Console.ReadLine());
            double salesmade = 0;
            double totalsalesmade = 0;
            int totalraiting = 0;

            for (int i = 1; i <= numComputers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                int raiting = currentNum % 10;
                int possiblesales = currentNum / 10;
                if (raiting == 2)
                {
                    salesmade = 0;
                    totalraiting += raiting;
                }
                else if (raiting == 3)
                {
                    salesmade = possiblesales * 0.50;
                    totalsalesmade += salesmade;
                    totalraiting += raiting;
                }
                else if (raiting == 4)
                {
                    salesmade = possiblesales * 0.70;
                    totalsalesmade += salesmade;
                    totalraiting += raiting;
                }
                else if (raiting == 5)
                {
                    salesmade = possiblesales * 0.85;
                    totalsalesmade += salesmade;
                    totalraiting += raiting;
                }
                else if (raiting == 6)
                {
                    salesmade = possiblesales;
                    totalsalesmade += salesmade;
                    totalraiting += raiting;
                }
                        
        }
            double averageraiting = totalraiting / (double)numComputers;
            Console.WriteLine($"{totalsalesmade:f2}");
            Console.WriteLine($"{averageraiting:f2}");
    }
    }
}
