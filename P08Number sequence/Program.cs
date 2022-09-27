using System;

namespace P08Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int maxnumber = int.MinValue;
            int minnumber = int.MaxValue;


            for(int i=1;  i<=n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if(currentNum>maxnumber)
                {
                  maxnumber = currentNum;
                }
                if(currentNum<minnumber)
                {
                    minnumber = currentNum;
                }
                
            }


            Console.WriteLine($"Max number: {maxnumber}");
            Console.WriteLine($"Min number: {minnumber}");



        }
    }
}
