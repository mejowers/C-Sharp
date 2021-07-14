using System;
using System.Collections.Generic;
using System.Text;

namespace Ch05_prj3_Guessing_Game {
    class GuessingGame {
        static void Main(string[] args) {

            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();


            // start game

            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("I am thinking of a number from 1 to 100.");
                Console.WriteLine("Try to guess it.");
                Console.WriteLine();

                Random rand = new Random();
                int number = rand.Next(1, 101);
                int count = 0;
                int guess = 0;

                Console.WriteLine("Hint: the number is: " + number);
                Console.WriteLine();

                
                while (guess != number) {
                    guess = getIntWithinRange("Enter number: ", 0, 101);
                    count++;
                    int diff = guess - number;
                    if (diff < -10) {
                        Console.WriteLine("Way too low!");
                    } else if (diff < 0) {
                        Console.WriteLine("Too low!");
                    } else if (diff > 10) {
                        Console.WriteLine("Way to high!");
                    } else if (diff > 0) {
                        Console.WriteLine("Too high!");
                    }
                }
                printWinner(count);
                Console.WriteLine();

                choice = getRequiredString("Try again? (y/n)", "y", "n");
            }

            Console.WriteLine();
            Console.WriteLine("Bye - Come back soon!");
        }
        private static void printWinner(int count) {
            Console.WriteLine();
            Console.WriteLine("You got it in " + count + " tries.");
            if (count <= 3) {
                Console.WriteLine("Great work! You are a mathematical wizard.");
            } else if (count <= 7) {
                Console.WriteLine("Not too bad! You've got some potential.");
            } else {
                Console.WriteLine("What took you so long? Maybe you should take some lessons");
            }
        }

        private static String getRequiredString(String prompt,
                                                            String s1, String s2) {
            String str = "";
            bool isValid = false;
            while (!isValid) {
                Console.WriteLine(prompt);
                str = Console.ReadLine().ToLower();
                if (!str.Equals(s1) && !str.Equals(s2)) {
                    Console.WriteLine("Invalid entry, try again.");
                } else {
                    isValid = true;
                }

            }
            return str;

        }
        public static int getIntWithinRange(String prompt,
                int min, int max) {
            int i = 0;

            bool isValid = false;
            i = Convert.ToInt32(Console.ReadLine());
            while (!isValid) {
                if (i <= min) {
                    Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                } else if (i >= max) {
                    Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                } else {
                    isValid = true;
                }
            }
            return i;
        }

    }
}



