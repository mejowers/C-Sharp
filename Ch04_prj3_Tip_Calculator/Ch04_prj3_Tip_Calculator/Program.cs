using System;

namespace Ch04_prj3_Tip_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter the cost of the meal: ");
                decimal cost = decimal.Parse(Console.ReadLine());


                for (double percent = 0.15; percent <= 0.25; percent += .05)
                {
                    Console.WriteLine("\n"+String.Format("{0:P0}", percent));
                    decimal tip = decimal.Multiply(cost, (decimal)percent);
                    decimal total = decimal.Add(cost, tip);
                    Console.WriteLine("Tip Amount: " + String.Format("{0:C2}", tip));
                    Console.WriteLine("Total: " + String.Format("{0:C2}", total));
                }

               /* Console.WriteLine("\n15%");
                decimal tip = decimal.Divide(15, 100);
                decimal tip15 = decimal.Multiply(cost, tip);
                decimal cost15 = decimal.Add(cost, tip15);
                Console.WriteLine("Tip Amount: " + String.Format("{0:C2}", tip15));
                Console.WriteLine("Total: " + String.Format("{0:C2}", cost15));

                Console.WriteLine("\n20%");
                decimal tip2 = decimal.Divide(20, 100);
                decimal tip20 = decimal.Multiply(cost, tip2);
                decimal cost20 = decimal.Add(cost, tip20);
                Console.WriteLine("Tip Amount: " + String.Format("{0:C2}", tip20));
                Console.WriteLine("Total: " + String.Format("{0:C2}", cost20));

                Console.WriteLine("\n25%");
                decimal tip3 = decimal.Divide(25, 100);
                decimal tip25 = decimal.Multiply(cost, tip3);
                decimal cost25 = decimal.Add(cost, tip25);
                Console.WriteLine("Tip Amount: " + String.Format("{0:C2}", tip25));
                Console.WriteLine("Total: " + String.Format("{0:C2}", cost25));*/


                Console.WriteLine("\nContinue (y/n)? ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("\nGood Bye!");
        }
    }
}
