using System;

namespace P07Min_Number_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string number;
            int minNumber= int.MaxValue;
            int currnNum = 0;

            while ((number = Console.ReadLine()) != "Stop")
            {
                currnNum = int.Parse(number);

                if (currnNum<minNumber )
                {
                    minNumber= currnNum;
                }


            }

            Console.WriteLine(minNumber);



        }
    }
}
