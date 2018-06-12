using System;

namespace Lab2
{
    internal class OverflowException : Lab2Exception
    {
        public OverflowException(string message)
            : base(message)
        {
        }
    }
}
