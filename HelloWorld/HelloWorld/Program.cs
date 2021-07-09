using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Good Bye");

            Console.WriteLine("Hello World!");

            String firstName = "Bob";
            string lastName = "Marley";

            int n1 = 5;
            int n2 = 7;

            int sum = n1 + n2;

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("sum =" + sum);

            // p.47 - var identifier
            var name1 = "Sam Brown";

            // single line comment

            /* 
             * multi line comment
             */

            //p.52
            double price1 = 25.99;

            Console.WriteLine("What's your name: ");
            String name2 = Console.ReadLine();

            Console.WriteLine("Hi, " + name2+"!!!!");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Continue?");
                choice = Console.ReadLine();

            }

            if (sum > 10)
            {
                Console.WriteLine("> 10");
            }
            else
            {
                Console.WriteLine("< 10");
            }

            Console.Write("enter a whole number: ");
            String nbrStr = Console.ReadLine();
            int nbr = Int32.Parse(nbrStr);

        }
    }
}
