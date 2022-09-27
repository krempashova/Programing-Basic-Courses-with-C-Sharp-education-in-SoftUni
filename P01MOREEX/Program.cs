using System;

namespace P01MOREEX
{
    internal class Program
    {
          static void Main()
        {

            //Градинар продавал реколтата от градината си на зеленчуковата борса.
            //Продава зеленчуци за N лева на килограм и плодове за M лева за килограм.
            //Напишете програма, която да пресмята приходите от реколтата в евро
            //( ако приемем, че едно евро е равно на 1.94лв).
            //От конзолата се четат 4 числа, по едно на ред:
            //•	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
            //Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
            //Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
            //Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]


            double npriceforkg = double.Parse(Console.ReadLine());
            double mpriceforkg = double.Parse(Console.ReadLine());
            int totalkgN = int.Parse(Console.ReadLine());
            int totalkgM=int.Parse(Console.ReadLine());


            double totalpriceforNMlv = (npriceforkg * totalkgN) + (mpriceforkg * totalkgM);
            double totalpriceforNMeuro = totalpriceforNMlv / 1.94;

            Console.WriteLine("{0:f2}", totalpriceforNMeuro);
        }
    }
}
