using System;

namespace PB_EXAMS_EXIRSECE_Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //•	На първия ред - капацитет на залата - цяло число в интервала [50... 150]
            //На всеки следващ ред до команда "Movie time!":
            // Брой хора влизащи в киното -цяло число в интервала[1… 15]

            int capacityroom = int.Parse(Console.ReadLine());
            double totalpricetickets = 0;
            int totalnumtickets = 0;
            string comand = "";
            while(comand!= "Movie time!")
            {
                comand = Console.ReadLine();
                    int numtickets=int.Parse(comand);
                    totalnumtickets += numtickets;

                
                if(numtickets%3==0)
                {
                    totalpricetickets = totalpricetickets - 5;
                }
                
                if(totalnumtickets>=capacityroom)
                {
                    break;
                }


            }



        }
    }
}