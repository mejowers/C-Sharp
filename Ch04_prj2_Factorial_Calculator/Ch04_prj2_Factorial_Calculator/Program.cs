using System;

namespace Ch04_prj2_Factorial_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter an integer that is greater than 0 and less than 10: ");
                int nbr = Int32.Parse(Console.ReadLine());

                long fact = 1;
                for (int i=1; i<=nbr; i++)
                {
                  fact *= i;
                }

                Console.WriteLine("\nThe Factorial for number " + nbr + " is: "+fact);

                Console.WriteLine("\nContinue (y/n)? ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("\nGood Bye!");
        }
    }
}
