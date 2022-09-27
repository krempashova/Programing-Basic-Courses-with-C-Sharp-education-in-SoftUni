using System;

namespace P09FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c= int.Parse(Console.ReadLine()) ;  
            double usedspace=double.Parse(Console.ReadLine()) ;

            double obemaqwarium = a * b * c;
            double obemaqwariumlitri = obemaqwarium / 1000;
            double totalusedspice = usedspace / 100;
            double totalusedspiceaqwarium = obemaqwariumlitri * totalusedspice;
            double totalwater = obemaqwariumlitri - totalusedspiceaqwarium;
            Console.WriteLine(totalwater);


        }
    }
}
 