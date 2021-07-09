using System;

namespace Ch03_prj4_Change_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calulator");

            String choice = "y";
            while (choice.Equals("y")) { 
            var cents = EnterCents();
            var origCents = cents;
            var quarters = cents / 25;
            cents -= quarters * 25;
            var dimes = cents / 10;
            cents -= dimes * 10;
            var nickels = cents / 5;
            cents -= nickels * 5;
            var pennies = cents;
            Console.WriteLine($"{origCents} cents is {quarters} quarters, {dimes} dimes, {pennies} pennies");

                Console.Write("\nContinue (y/n): ");
                choice = Console.ReadLine();
            }

           Console.WriteLine("\nThank you for using the change calculator!");
        }
        static int EnterCents()
        {
            Console.Write("Enter the number of cents: ");
            var centsStr = Console.ReadLine();
            var cents = Int32.Parse(centsStr);
            return cents;
        }
    }
}
