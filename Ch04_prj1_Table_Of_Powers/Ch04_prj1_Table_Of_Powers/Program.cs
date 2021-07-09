using System;

namespace Ch04_prj1_Table_Of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("\nEnter an Integar: ");
                int nbr = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nNumber  Squared  Cubed");
                Console.WriteLine("======  =======  =====");

                for (int i = 1; i <= nbr; i++)
                {
                    Console.WriteLine(i + "\t" + (i * i) + "\t" + " "+(i * i * i));
                }

                Console.Write("\nContinue (y/n)? ");
                choice = Console.ReadLine();

            }
            Console.WriteLine("\nGood Bye!");
        }
    }
}
