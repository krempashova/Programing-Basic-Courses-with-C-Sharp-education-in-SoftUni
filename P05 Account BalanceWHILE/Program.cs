using System;

namespace P05_Account_BalanceWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command;
             double sum = 0;


            while((command=Console.ReadLine()) != "NoMoreMoney")
            {
                double contribution = double.Parse(command);

                if(contribution<0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;

                }
                sum += contribution;
                Console.WriteLine($"Increase: {contribution:f2}");



            }

            Console.WriteLine($"Total: {sum:f2}");





        }
    }
}
