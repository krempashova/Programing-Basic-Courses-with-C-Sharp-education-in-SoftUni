using System;

namespace P03Sum_Prime_Non_PrimeNesteedLopp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int sumPrimeNum = 0;
            int sumNonPrimeNum = 0;

          while(input!="stop")
            {
                input= Console.ReadLine();  
                
                if(input=="stop")
                {
                    break;
                }

                int num =int.Parse(input);

                if(num<0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool numberIsPrime = true;
                int loopend = num - 1;

                for(int diveder=2;diveder<loopend;diveder++)
                {
                    int remainder = num % diveder;

                    if(remainder==0)
                    {
                        sumNonPrimeNum += num;
                        numberIsPrime = false;
                        break;
                    }

               }
                if(numberIsPrime)
                {
                    sumPrimeNum += num;
                }
               
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNum}");




        }
    }
}
