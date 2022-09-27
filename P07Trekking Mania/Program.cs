using System;

namespace P07Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            int groupsNum = int.Parse(Console.ReadLine());

            int peopleGoMusala = 0;
            int peopleGoMonblanc = 0;
            int peopleGoKilimandjaro = 0;
            int peopleGoK2 = 0;
            int peopleGoEverest = 0;

            int allpeople = 0;

            for(int i=1;i<=groupsNum; i++)
            {
                int peopleInGroup=int.Parse(Console.ReadLine());
                allpeople += peopleInGroup;

                if (peopleInGroup>=1 && peopleInGroup<=5)
                {
                    peopleGoMusala += peopleInGroup;

                }
                else if(peopleInGroup>=6 && peopleInGroup<=12)
                {
                    peopleGoMonblanc += peopleInGroup;
                }
                else if(peopleInGroup>=13 && peopleInGroup<=25)
                {
                    peopleGoKilimandjaro += peopleInGroup;
                }
                else if(peopleInGroup>=26 && peopleInGroup<=40)
                {
                    peopleGoK2 += peopleInGroup;
                }
                else if(peopleInGroup>=41)
                {
                    peopleGoEverest += peopleInGroup;
                }
            }

            double procentigeMusala = ((double)peopleGoMusala / allpeople) * 100;
            Console.WriteLine($"{procentigeMusala:f2}%");
            double procentigeMonblanc = ((double)peopleGoMonblanc / allpeople)* 100;

            Console.WriteLine($"{procentigeMonblanc:f2}%");
            double procentigeKilimandjaro = ((double)peopleGoKilimandjaro / allpeople) * 100;
            Console.WriteLine($"{procentigeKilimandjaro:f2}%");
            double procentigeK2 = ((double)peopleGoK2 / allpeople) * 100;
            Console.WriteLine($"{procentigeK2:f2}%");
            double procentigeEverest = ((double)peopleGoEverest / allpeople )* 100;
            Console.WriteLine($"{procentigeEverest:f2}%");



        }
    }
}
