using System;

namespace P06BuildingNesteedLopps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsNUM = int.Parse(Console.ReadLine());

            int roomsNum = int.Parse(Console.ReadLine());

            for (int fl = floorsNUM; fl >= 1; fl--)
            {
                Console.WriteLine();
                for (int room = 0;room < roomsNum;room++)
                {

                    
                    if(fl==floorsNUM)
                    {
                        Console.Write($"L{fl}{room} ");
                    }

                   else if(fl%2 ==0)
                    {
                        Console.Write($"O{fl}{room} ");
                    }
                    else if(fl %2!=0)
                    {
                        Console.Write($"A{fl}{room} ");
                    }
                    
                }
            }







        }
    }
}
