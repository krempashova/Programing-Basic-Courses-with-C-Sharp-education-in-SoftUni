using System;

namespace p07areaS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           string figuretype=Console.ReadLine();
            double area = 0;

            if (figuretype == "square") 
            {
                 double a = double.Parse(Console.ReadLine());
                  area = a * a;
                   
            }
            else if (figuretype=="rectangle")
            {
                   double a=double.Parse(Console.ReadLine());
                   double b=double.Parse(Console.ReadLine()) ;
                     area = a * b;
                  
            }
            else if (figuretype== "circle")
            {
                double r = double.Parse(Console.ReadLine());
                 area = Math.PI * r * r;
                
                

            }
            else if (figuretype== "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double hc = double.Parse(Console.ReadLine());
                 area = (c * hc) / 2;

               
            }

                   Console.WriteLine($"{area:F3}");
        }
    }
}
