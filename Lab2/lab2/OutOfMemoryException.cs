using System;

namespace Lab2
{
    internal class OutOfMemoryException : Lab2Exception
    {
        public OutOfMemoryException(string message)
            : base(message)
        {
        }
    }
}
