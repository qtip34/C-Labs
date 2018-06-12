using System;

namespace Lab2
{
    internal class IndexOutOfRangeException : Lab2Exception
    {
        public IndexOutOfRangeException(string message)
            : base(message)
        {
        }
    }
}
