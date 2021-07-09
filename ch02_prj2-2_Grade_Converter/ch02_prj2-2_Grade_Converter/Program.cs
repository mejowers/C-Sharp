using System;

namespace ch02_prj2_2_Grade_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter Numerical grade: ");
                
                String numGradeStr = Console.ReadLine();
                int numGrade = Int32.Parse(numGradeStr);

                String letterGrade = "F";
                if (numGrade >= 88)
                {
                    letterGrade = "A";
                }
                else if (numGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if (numGrade >= 68)
                {
                    letterGrade = "C";
                }
                else if (numGrade >= 60)
                {
                    letterGrade = "D";
                }

                Console.WriteLine("Letter grade: " + letterGrade);
                Console.WriteLine();
                Console.Write("Continue (y/n)? ");
                choice = Console.ReadLine();

                Console.WriteLine("Thank you for using the Grade Converter!");
            }
        }
    }
}
