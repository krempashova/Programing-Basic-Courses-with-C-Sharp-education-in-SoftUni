using System;

namespace P02Equal_Sums_Even_Odd_PositionNesteedLoopex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstsum = int.Parse(Console.ReadLine());
            int secondsum = int.Parse(Console.ReadLine());
            for(int i=firstsum;i<=secondsum;i++)
            {
                string currnumber=i.ToString();
                int evensum = 0;
                int oddsum = 0;

                for(int j=0;j<currnumber.Length;j++)
                {
                    int currDigit= int.Parse(currnumber[j].ToString());
                    if(j %2==0)
                    {
                        evensum += currDigit;
                    }
                    else 
                    {
                        oddsum += currDigit;
                    }

                }
                if(evensum==oddsum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
