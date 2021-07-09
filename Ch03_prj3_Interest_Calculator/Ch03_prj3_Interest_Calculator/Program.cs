using System;

namespace Ch03_prj3_Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator\n");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter Loan Amount: ");
                decimal loan = decimal.Parse(Console.ReadLine());
                
                Console.Write("Enter the interest rate: ");
                decimal intRate = decimal.Parse(Console.ReadLine());
                decimal loanAmt = decimal.Multiply(loan, intRate);


                Console.WriteLine("\nLoan Amount: " + String.Format("{0:C2}", loan, MidpointRounding.AwayFromZero));
                Console.WriteLine("Interest Rate: "+ String.Format("{0:P3}", intRate, MidpointRounding.AwayFromZero));
                Console.WriteLine("InterestAmount: " + decimal.Round(loan * intRate, 2, MidpointRounding.AwayFromZero));

                
                Console.Write("\nContinue (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Good Bye!");
        }
    }
}
