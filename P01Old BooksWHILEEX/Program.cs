using System;

namespace P01Old_BooksWHILEEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteAnisbook = Console.ReadLine();
            string enteredbook = "";
            int counter = 0;

           while(enteredbook!=favoriteAnisbook && enteredbook!= "No More Books")
            {
                enteredbook=Console.ReadLine();

                           

                if(enteredbook==favoriteAnisbook)
                {
                     
                    Console.WriteLine($"You checked {counter-1} books and found it.");
                }
                if (enteredbook=="No More Books")
                {
                    break;
                }
                    



           }

           if(enteredbook=="No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter-1} books.");
            }








        }
    }
}
