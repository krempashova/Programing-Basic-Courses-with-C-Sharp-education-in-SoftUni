using System;

namespace P01Numbers_Ending_in_7EXERCISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }

            }
             
        }
    }
}
