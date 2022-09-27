using System;

namespace P05Traininglab
{
    internal class Program
    {
        static void Main()
        {
           

            double nylon = double.Parse(Console.ReadLine());
            double paint=double.Parse(Console.ReadLine());
          double accetone = double.Parse(Console.ReadLine());
           double hours =double.Parse(Console.ReadLine());
            double totalnylon = (nylon + 2) * 1.50;
            double paint10procetnige = paint + (paint * 0.1);
            double totalpaint =paint10procetnige * 14.50;
            double totalaccetone = accetone * 5.00;
            double bag = 0.40;
            double totalsumforremont = totalnylon + totalpaint + totalaccetone + bag;
            double procetnigeselary = (totalsumforremont * 0.3)* hours;
            double totalsumafterselary = totalsumforremont + procetnigeselary;

            Console.WriteLine(totalsumafterselary);








        }
    }
}
