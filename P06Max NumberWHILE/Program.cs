using System;

namespace P06Max_NumberWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string number;
           int  MaxNum = int.MinValue;
            int currnNum = 0;

             while ((number=Console.ReadLine()) !="Stop")
            {
                 currnNum=int.Parse(number);

                if (currnNum > MaxNum)
                {
                   MaxNum=currnNum;
                }
              

            }

            Console.WriteLine(MaxNum);

        }
    }
}
