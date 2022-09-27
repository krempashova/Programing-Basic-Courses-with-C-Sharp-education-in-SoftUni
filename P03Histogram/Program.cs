using System;

namespace P03Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int allnum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                allnum = n;

                if (num<200)
                {
                    p1 ++;
                }
                else if(num>=200 && num <=399)
                {
                    p2 ++;
                }
                else if(num>=400 && num <=599)
                {
                    p3 ++;
                }
                else if(num>=600 && num<=799)
                {
                    p4 ++;
                }
                else if(num>=800)
                {
                    p5 ++;
                }

            }

            double pricentigeP1 = ((double)p1 / allnum) * 100;
            Console.WriteLine($"{pricentigeP1:f2}%");
            double pricentigep2 = ((double)p2 / allnum )* 100;
            Console.WriteLine($"{pricentigep2:f2}%");
            double pricentigep3= ((double) p3 / allnum )* 100;
            Console.WriteLine($"{pricentigep3:f2}%");
            double pricentigep4=((double)p4 / allnum) * 100;
            Console.WriteLine($"{pricentigep4:f2}%");
            double pricentigep5=((double) p5 / allnum) * 100;
            Console.WriteLine($"{pricentigep5:f2}%");

            



        }
    }
}
