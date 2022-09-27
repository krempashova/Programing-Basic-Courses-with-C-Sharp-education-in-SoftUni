using System;

namespace P02Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxnum = int.MinValue;

            for(int i=0;i<n;i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if(num>maxnum)
                {
                    maxnum = num;
                }
            }
            int sumWithotmaxnum = sum - maxnum;
            if(sumWithotmaxnum==maxnum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + maxnum);
            }
            else
            {
                int Diff = Math.Abs(maxnum - sumWithotmaxnum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " +Diff );
            }




        }
    }
}
