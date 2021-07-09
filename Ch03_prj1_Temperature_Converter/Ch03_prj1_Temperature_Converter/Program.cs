using System;

namespace Ch03_prj1_Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter \n");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                String tempStr = Console.ReadLine();
                double temp = double.Parse(tempStr);
                double celcTemp = (((temp - 32) * 5 / 9) * 100) / 100;
                               
                Console.WriteLine("Celcius: " + Math.Round(celcTemp, 2)+"\n");

                Console.Write("Continue (y/n)? ");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Thank you for using the Temperature Converter!");
        }
    }
}
