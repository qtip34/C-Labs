using System;

namespace Lab2
{
    internal class StackOverflowException : Lab2Exception
    {
        public StackOverflowException(string message)
            : base(message)
        {
        }
    }
}
