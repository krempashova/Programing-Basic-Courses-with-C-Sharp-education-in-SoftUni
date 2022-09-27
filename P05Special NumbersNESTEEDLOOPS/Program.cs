using System;

namespace P05Special_NumbersNESTEEDLOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i=1111;i<=9999;i++)
            {

                int iTWIN = i;
                bool isSpecial = true;
                for (int j = 1; j <= 4; j++)
                {
                    int lastDigit = iTWIN % 10;
                    if (lastDigit == 0)
                    {

                        isSpecial = false;
                        break;
                    }
                    int remaider = n % lastDigit;

                    if (remaider != 0)
                    {
                        isSpecial = false;
                        break;
                    }



                    iTWIN /= 10;
                }

                if(isSpecial)
                {
                    Console.Write($"{i} ");
                }


            }



        }
    }
}
