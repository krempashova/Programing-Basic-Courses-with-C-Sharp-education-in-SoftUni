using System;

namespace P06Cake_whileex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heightCake=int.Parse(Console.ReadLine());
            int widthCake = int.Parse(Console.ReadLine());

            int piesesCake = heightCake * widthCake;
            
            
;            while (piesesCake>0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int takenPiecesCake = int.Parse(input);

                piesesCake -= takenPiecesCake;
            }



           if(piesesCake>0)
            {
                Console.WriteLine($"{piesesCake} pieces are left.");
            }


             
            

            else
            {
                int insufficientPiesesCake = Math.Abs(piesesCake);

                Console.WriteLine($"No more cake left! You need {insufficientPiesesCake} pieces more.");
            }
                
            





        }
    }
}
