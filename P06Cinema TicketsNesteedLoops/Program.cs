using System;

namespace P06Cinema_TicketsNesteedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalTicketsForDay = 0;

            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string input = "";
            while(input!="Finish")
            {
                input = Console.ReadLine(); 
                if(input=="Finish")
                {
                    break;
                }

                string FilmName = input;
                int availableSeats = int.Parse(Console.ReadLine());
                int currentAvailableseats = availableSeats;
                int ticketSoldForFlm = 0;
                string TicketType = "";
                while (TicketType != "End" && currentAvailableseats > 0)
                {
                    TicketType = Console.ReadLine();
                    if (TicketType == "End")
                        break;



                    ticketSoldForFlm++;
                    totalTicketsForDay++;
                    currentAvailableseats--;
                    switch (TicketType)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }
                }
                double percentageFull = ticketSoldForFlm / (availableSeats * 1.0) * 100;
                Console.WriteLine($"{FilmName} - {percentageFull:f2}% full.");
            }


            Console.WriteLine($"Total tickets: {totalTicketsForDay}");

            double percStudents = studentTickets / (totalTicketsForDay * 1.0) * 100;
            Console.WriteLine($"{percStudents:f2}% student tickets.");

            double percStandard = standardTickets / (totalTicketsForDay * 1.0) * 100;
            Console.WriteLine($"{percStandard:f2}% standard tickets.");

            double percKids = kidTickets / (totalTicketsForDay * 1.0) * 100;
            Console.WriteLine($"{percKids:f2}% kids tickets.");


        }
    }
}
