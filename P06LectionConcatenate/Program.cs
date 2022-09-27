using System;

namespace P06LectionConcatenate
{
    internal class Program
    {
        static void Main()
        {
            //Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата следното съобщение:
            //"You are <firstName> <lastName>, a <age>-years old person from <town>."

           string firstname= Console.ReadLine();

           string lastname = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstname} {lastname}, a {age}-years old person from {town}.");



            
                   

        }
    }
}
