using System;

namespace P09Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftsum = 0;
            int rightsum = 0;
            for (int i = 1; i <= n; i++)

            {
                leftsum = leftsum + int.Parse(Console.ReadLine());
            }
                for (int i = 1; i <= n; i++)
            {
                rightsum = rightsum + int.Parse(Console.ReadLine());
            }
            

                if(leftsum==rightsum)
                {
                Console.WriteLine($"Yes, sum = " +leftsum);
                }
            else
            {
                int diff = Math.Abs(leftsum - rightsum);
                Console.WriteLine($"No, diff = " +diff);
            }


        }
    }
}
