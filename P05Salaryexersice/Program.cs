using System;

namespace P05Salaryexersice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int openTabsNum = int.Parse(Console.ReadLine());

            int saalary = int.Parse(Console.ReadLine());


            for (int i = 1; i <= openTabsNum; i++)
            {
                string websitesName = Console.ReadLine();

                switch (websitesName)
                {

                    case "Facebook":
                        saalary -= 150;
                        break;
                    case "Instagram":
                        saalary -= 100;
                        break;
                    case "Reddit":
                        saalary -= 50;
                        break;

                        if (saalary <= 0)
                        {
                            break;
                        }
                }
            }

                if(saalary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                }
                else
                {
                    Console.WriteLine($"{saalary}");
                }
                
            





        }
    }
}
