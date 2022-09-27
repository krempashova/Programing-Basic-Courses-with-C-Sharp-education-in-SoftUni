using System;

namespace P05TravellingNesteedlopp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desstination = "";
            int savedMoney = 0;
            string input;
            while((input=Console.ReadLine())!="End")
            {
                int budget = int.Parse(Console.ReadLine());
                desstination = input;
                while(savedMoney<budget)
                {
                    savedMoney +=int.Parse(Console.ReadLine());

                   if(savedMoney>=budget)
                    {
                        Console.WriteLine($"Going to {desstination} !");
                      
                        break;
                        
                    }


                }

            }

            


        }
    }
}
