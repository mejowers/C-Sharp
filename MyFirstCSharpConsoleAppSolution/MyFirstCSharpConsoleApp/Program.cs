using System;

namespace MyFirstCSharpConsoleApp
{
    class Program
    {
        readonly int nbr;
        static void Main(string[] args)
        {
            var hw = "Hello, World";
            Console.WriteLine(hw);
        }

        public Program(int inta)
        {
            this.nbr = inta;
        }

    }
}
