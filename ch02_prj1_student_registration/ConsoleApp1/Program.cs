using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");

           Console.WriteLine("Enter First Name: ");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            String lastName = Console.ReadLine();
             Console.WriteLine("Enter year of Birth: ");
           String birthYearStr = Console.ReadLine();
            int birthYear = Int32.Parse(birthYearStr);

            Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration in complete!");

            Console.WriteLine("Your password is: " + firstName + "*" + birthYear);

            Console.WriteLine("Thank you for using the registration app.");
        }
    }
}
