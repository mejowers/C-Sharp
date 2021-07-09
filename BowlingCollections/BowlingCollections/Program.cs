using System;

namespace BowlingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Bowling();
            Console.WriteLine($"Game Score is: {game.Bowl()}");

        }
    }
}
