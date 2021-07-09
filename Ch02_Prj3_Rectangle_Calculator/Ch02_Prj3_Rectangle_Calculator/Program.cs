using System;

namespace Ch02_Prj3_Rectangle_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter Length: ");
                String lengthStr = Console.ReadLine();
                int length = Int32.Parse(lengthStr);

                Console.Write("Enter Width: ");
                String widthStr = Console.ReadLine();
                int width = Int32.Parse(widthStr);

                int sumArea = length * width;

                Console.WriteLine("Area: " + sumArea);

                int sumPerimeter = (length * 2) + (width * 2);
                Console.WriteLine("Perimeter: " + sumPerimeter);

                Console.WriteLine("\n Continue (y/n)? ");
                choice = Console.ReadLine();

            }

            Console.WriteLine("Good Bye!");
        }
    }
}
