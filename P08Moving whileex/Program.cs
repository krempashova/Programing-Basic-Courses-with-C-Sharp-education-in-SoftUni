using System;

namespace P08Moving_whileex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int widthapartment = int.Parse(Console.ReadLine());

            int hightapartment=int.Parse(Console.ReadLine());

            int lenghapartment = int.Parse(Console.ReadLine());

            int volumeapartment = widthapartment * hightapartment * lenghapartment;

            while(volumeapartment > 0)
            {
                string input = Console.ReadLine();

                if(input=="Done")
                {
                    break;
                }

                volumeapartment -= int.Parse(input);
            }
            if(volumeapartment>0)
            {
                Console.WriteLine($"{volumeapartment} Cubic meters left.");
            }
            else
            {
                int insufficientspace = Math.Abs(volumeapartment);
                Console.WriteLine($"No more free space! You need { insufficientspace} Cubic meters more.");
            }


                


        }
    }
}
