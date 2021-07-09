using System;

namespace NumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers App!");

            Random rand = new Random();
            Console.WriteLine("Random #=" + rand.Next());
          
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("die roll = " + rand.Next(1, 7));
            }

            // round to 3 decimal places, half up
            double d1 = Math.Round(25.3456789, 3, MidpointRounding.AwayFromZero);
            Console.WriteLine(d1.ToString "c");

            



            Console.WriteLine("Good Bye!");
        }
    }
}
