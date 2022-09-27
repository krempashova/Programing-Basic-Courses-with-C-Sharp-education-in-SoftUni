using System;

namespace P06Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int currentnumer = int.Parse(Console.ReadLine());
            int currentnumerTWIN = currentnumer;
            int multiplicator = currentnumerTWIN / 100;
            int thyrdsigh = currentnumerTWIN % 10;
            int secondsigh = (currentnumerTWIN / 10) % 10;
             
             for(int j = 1; j <= thyrdsigh; j++)
            {
                for(int n=1;n<=secondsigh;n++)
                {

                    for(int number = 1; number <= multiplicator; number++)
                    {
                        int result = j * n * number;
                        Console.WriteLine($"{j} * {n} * {number} = { result};");
                    }
                }
            }








        }
    }
}
