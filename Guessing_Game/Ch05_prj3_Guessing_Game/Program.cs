using System;

namespace Ch05_prj3_Guessing_Game {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            int count = 0;
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("\nI am thinking of a whole number between 1 and 100. " +
                                              "\nTry to guess it!");
                Console.Write("Number Guess: ");
                int guess = Int32.Parse(Console.ReadLine());
                count++;

                Random rand = new Random();
                decimal num = rand.Next(1, 101);
                 while (guess != num) {
                        if (guess < (num - 10)) {
                            Console.WriteLine("Way too Low!");
                        } if (guess > (num + 10)) {
                            Console.WriteLine("Way too High!");
                        } if (guess > num) {
                            Console.WriteLine("Too High");
                        } if (guess < num) {
                            Console.WriteLine("Too Low");
                       
                    Console.WriteLine($"Try Again (y/n)? ");
                    choice = Console.ReadLine().ToLower();
                    Console.WriteLine();
                }
                

                while (guess == num) {
                    Console.WriteLine($"You guess it in {count} tries!");
                    if (count <= 3) {
                        Console.WriteLine($"\nGreat Work! You are a mathematical wizard!");
                    }
                    if (count > 3 && count <= 7) {
                        Console.WriteLine($"\nNot too bad! You have potential!");
                    }
                    if (count > 7) {
                        Console.WriteLine($"\n What took you so long? " +
                                          $"You might want to take some lessons.");
                    }
                 
                }
          
            }
        }
    }
}

