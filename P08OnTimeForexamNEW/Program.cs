using System;

namespace P08OnTimeForexamNEW
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int hourstartexam = int.Parse(Console.ReadLine());//8
            int minutestartexam = int.Parse(Console.ReadLine());//30
            int hourStudentAraive = int.Parse(Console.ReadLine());//9
            int minutesStudentAraive = int.Parse(Console.ReadLine());//59

            int hourStarexamInMinutes = hourstartexam * 60 + minutestartexam;//510
            int hoursStudentaraiveInMinutes = hourStudentAraive * 60 + minutesStudentAraive;//599

            int differenceInMinutes = hourStarexamInMinutes - hoursStudentaraiveInMinutes;

            int hours=differenceInMinutes / 60;
            int leftminutes = differenceInMinutes % 60;


            if(differenceInMinutes>=0 &&differenceInMinutes<=30)
            {
                Console.WriteLine("On time");
                if(differenceInMinutes>=1)
                {
                    Console.WriteLine($"{differenceInMinutes} minutes before the start");
                }
            }
            else if(differenceInMinutes>30)
            {
                if(differenceInMinutes<=59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceInMinutes} minutes before the start");
                }
                else
                {

                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{leftminutes:d2} hours before the start");
                }
                        
            }
            else if(differenceInMinutes<0)
            {
                differenceInMinutes = Math.Abs(differenceInMinutes);
                if(differenceInMinutes<=59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differenceInMinutes} minutes after the start ");
                }
                else
                {
                    hours = Math.Abs(hours);
                    leftminutes = Math.Abs(leftminutes);
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{leftminutes:d2} hours after the start");
                }
                        
                
            }





        }
    }
}
