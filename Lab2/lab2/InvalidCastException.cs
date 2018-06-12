using System;

namespace Lab2
{
    internal class InvalidCastException : Lab2Exception
    {
        public InvalidCastException(string message)
            : base(message)
        {
        }
    }
}
