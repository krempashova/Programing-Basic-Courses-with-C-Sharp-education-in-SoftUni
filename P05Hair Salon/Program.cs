using System;

namespace P05Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalForAday = int.Parse(Console.ReadLine());
            double savedmONEY = 0;
             double price = 0;
            string input = "";
            while(input!= "closed"&&savedmONEY<goalForAday)
            //haircut" и "color". 
            {
                input =Console.ReadLine();
                if (input == "haircut")//mens", "ladies" или "kids".
                {
                    string typeOfHaircut = Console.ReadLine();
                    if (typeOfHaircut == "mens")
                    {
                        price = 15.00;
                        savedmONEY += price;
                    }
                    else if (typeOfHaircut == "ladies")
                    {
                        price = 20.00;
                        savedmONEY += price;
                    }
                    else if (typeOfHaircut == "kids")
                    {
                        price = 10.00;
                        savedmONEY += price;
                    }
                }

                else if (input == "color")
                {
                    string typeofColoring = Console.ReadLine();
                    if (typeofColoring == "touch up")
                    {
                        price = 20.00;
                        savedmONEY += price;
                    }
                    else if (typeofColoring == "full color")
                    {
                        price = 30.00;
                        savedmONEY += price;
                    }
                }

                if (input == "closed")
                {
                    break;
                   
                }                
             
            }
            if(savedmONEY>=goalForAday)
            {
                Console.WriteLine($"You have reached your target for the day!") ;
                Console.WriteLine($"Earned money: {savedmONEY}lv.");

            }
            else
            {
                double insufficientMoney = goalForAday - savedmONEY;
                Console.WriteLine($"Target not reached! You need {insufficientMoney}lv. more.");
                Console.WriteLine($"Earned money: {savedmONEY}lv.");
            }
        }
    }
}
