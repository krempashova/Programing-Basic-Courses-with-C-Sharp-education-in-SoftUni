using System;

namespace P08Backetballequpmant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualsubscr = int.Parse(Console.ReadLine());

            double sneakers = annualsubscr - (annualsubscr * 0.40);
            double outfit = sneakers - (sneakers * 0.20);
            double ball = outfit / 4;
            double accesoaries = ball / 5;
            double totalprice = annualsubscr+sneakers + outfit + ball + accesoaries;
            Console.WriteLine(totalprice);
        }
    }
}
