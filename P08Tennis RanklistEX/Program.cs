using System;

namespace P08Tennis_RanklistEX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int TournNumber = int.Parse(Console.ReadLine());
            int pointsRangList=int.Parse(Console.ReadLine());
            int pointsThisYear = 0;

            int winsCounter = 0;

             for( int i =1;i<=TournNumber;i++ )
            {

                string position = Console.ReadLine();
                switch(position)

                {
                    case "W":
                        pointsThisYear += 2000;
                        winsCounter++;

                        break;
                    case "F":
                        pointsThisYear += 1200;
                            break;
                    case "SF":
                        pointsThisYear += 720;
                        break;
                }

            }
            int finalPoints = pointsRangList + pointsThisYear;

            Console.WriteLine($"Final points: {finalPoints}");


            double averagePoints=Math.Floor(pointsThisYear/(double)TournNumber);
               Console.WriteLine($"Average points: {averagePoints}");
            double procentigewin = (winsCounter /(double) TournNumber) * 100;

            Console.WriteLine($"{procentigewin:f2}%");







        }
    }
}
