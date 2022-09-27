using System;

namespace P08On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int hourOfexam = int.Parse(Console.ReadLine());//9
            int minuteOfexam = int.Parse(Console.ReadLine()); //30   //570
            int hourOfAraive=int.Parse(Console.ReadLine());//9
            int minuteOfAraive=int.Parse(Console.ReadLine());//50  // 590

            int timeOfexamInminutes = hourOfexam * 60 + minuteOfexam; //570
            int timeofAraiveInMinutes=hourOfAraive*60+ minuteOfAraive;  //590
            int diferenceInMinutes = timeOfexamInminutes - timeofAraiveInMinutes;
            int diferenceHour = diferenceInMinutes / 60;
            int remainingMinutesinindiference = diferenceInMinutes % 60;

            if(diferenceInMinutes>=0 && diferenceInMinutes<=30)
            {
                Console.WriteLine("On time");
                if(diferenceInMinutes>1)
                {
                    Console.WriteLine($"{diferenceInMinutes} minutes before the start");
                }
            }

            else if(diferenceInMinutes>30)
            {
                Console.WriteLine("Early");
                if(diferenceInMinutes<=59)
                {
                    Console.WriteLine($"{diferenceInMinutes} minutes before the start");
                }
                else 
                {
                    Console.WriteLine($"{diferenceHour} : {remainingMinutesinindiference} hours before the start");
                }
            }

            else if(diferenceInMinutes<0)
            {
                diferenceInMinutes = Math.Abs(diferenceInMinutes);
                Console.WriteLine("Late");
                if(diferenceInMinutes<=59)
                {
                    Console.WriteLine($"{diferenceInMinutes} minutes after the start");
                }
                else
                {
                    diferenceHour = Math.Abs(diferenceHour);
                    remainingMinutesinindiference = Math.Abs(remainingMinutesinindiference);

                    Console.WriteLine($"{diferenceHour}:{remainingMinutesinindiference:d2} hours after the start");
                }
            }




        }
    }
}
