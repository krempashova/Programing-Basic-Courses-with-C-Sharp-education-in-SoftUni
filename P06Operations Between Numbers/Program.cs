using System;

namespace P06Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //„+“, „-“, „*“, „/“, „%“

            int numOne = int.Parse(Console.ReadLine());
            int numTwo=int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double mathresult = 0;

            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (operation == '+')
                {
                    mathresult = numOne + numTwo;
                }
                else if (operation == '-')
                {
                    mathresult = numOne - numTwo;
                }
                else if (operation == '*')
                {
                    mathresult = (double)numOne * numTwo;
                }
                if (mathresult % 2 == 0)
                {
                    Console.WriteLine($"{numOne} {operation} {numTwo} = {mathresult} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} {operation} {numTwo} = {mathresult} - odd");
                }
            }
            else if (operation=='/'||operation=='%')
            {
                if(numTwo==0)
                {
                    Console.WriteLine($"Cannot divide {numOne} by zero");
                }
                else if (operation=='/')
                {
                    mathresult = (double)numOne / numTwo;
                    Console.WriteLine($"{numOne} {operation} {numTwo} = {mathresult:f2}");
                }
                else if (operation=='%')
                {
                    mathresult = (double)numOne % numTwo;
                    Console.WriteLine($"{numOne} {operation} {numTwo} = {mathresult}");
                }
                
            }


        }
    }
}
