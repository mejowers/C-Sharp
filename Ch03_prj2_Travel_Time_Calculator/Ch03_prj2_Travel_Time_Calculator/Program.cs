using System;
namespace Ch03_prj2_Travel_Time_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator!");
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter Miles: ");
                double miles = double.Parse(Console.ReadLine());
                Console.Write("Enter miles per hour: ");
                double mph = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------");
                double hours = miles / mph;
                int minutes = (int)(hours * 60);
                int hoursInt = minutes / 60;
                minutes = minutes % 60;
                Console.WriteLine("Hours: " + hoursInt);
                Console.WriteLine("Minutes: " + minutes);
                Console.Write("\n Continue (y/n)? ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using the Travel Calculator!");
        }
    }
}
