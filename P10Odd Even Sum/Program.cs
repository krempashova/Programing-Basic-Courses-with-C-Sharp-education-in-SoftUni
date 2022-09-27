using System;

namespace P10Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int oddsum = 0;
            int evensum = 0;
            for(int i=1;i<=n;i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    evensum += currentNum;
                }
                else
                {
                    oddsum  += currentNum;
                }
            }
            if(evensum==oddsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = "+evensum);
            }
            else
            {
                int Diff = Math.Abs(evensum - oddsum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + Diff);
            }









        }
    }
}
