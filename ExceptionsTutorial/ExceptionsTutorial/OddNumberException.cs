using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsTutorial
{
   public class OddNumberException : Exception 
    {
        public int OddNumber { get; set; }

        public OddNumberException(int Nbr)
            : base()
        {
            OddNumber = Nbr;
        }
        public OddNumberException() 
            : base() { }
        public OddNumberException(string Message)
            : base(Message) { }
        public OddNumberException(string Message, Exception InnerException)
            : base(Message, InnerException) { }

    }
}
