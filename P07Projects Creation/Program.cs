using System;

namespace P07Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява колко часа ще са необходими на един архитект,
            //за да изготви проектите на няколко строителни обекта.
            //Изготвянето на един проект отнема три часа.
            //От конзолата се четат 2 реда:
            //1.Името на архитекта -текст
            //     .Брой на проектите, които трябва да изготви - цяло число в интервала[0 … 100]
           
            //На конзолата се отпечатва:
            //	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            string namearchitect = Console.ReadLine();
            int numberofprojects=int.Parse(Console.ReadLine());
            int houre = numberofprojects * 3;
            Console.WriteLine($"The architect {namearchitect} will need {houre} hours to complete {numberofprojects} project/s.");


        }
    }
}
