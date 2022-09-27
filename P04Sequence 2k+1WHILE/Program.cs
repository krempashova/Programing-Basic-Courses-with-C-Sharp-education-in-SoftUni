using System;

namespace P04Sequence_2k_1WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter <=n)
            {
                Console.WriteLine(counter);

                counter = counter * 2 + 1;
            }

        }
    }
}
