using System;

namespace Ch05_prj1_Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller!");
            Console.WriteLine();

            Console.Write("Roll the Dice (y/n): ");
            string choice = Console.ReadLine().ToLower();
            Console.WriteLine();

            Random rand = new Random();

            while(choice.Equals("y")) {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                Console.WriteLine($"Die 1: {die1}");
                Console.WriteLine($"Die 2: {die2}");
                Console.WriteLine($"Total: {die1 + die2}");

                if (die1+die2 == 2) {
                    Console.WriteLine("Snake Eyes!");
                } if (die1+die2==12)
                {
                    Console.WriteLine("Box Cars!");
                }
                
                Console.Write("\nRoll again (y/n)? ");
                choice = Console.ReadLine();
            }
            
        }
    }
}
