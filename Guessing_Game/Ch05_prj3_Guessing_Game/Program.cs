using System;

namespace Ch05_prj3_Guessing_Game {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("\nI am thinking of a number between 1 and 100. " +
                                              "\nTry to guess it!");
                Console.Write("Number Guess: ");
                int guess = Int32.Parse(Console.ReadLine());
                

            }









            Random rand = new Random();
            int num = rand.Next(1, 101);
            Console.WriteLine("Enter number: ");
            int guess = Int32.Parse(Console.ReadLine());



        }
    }
}
