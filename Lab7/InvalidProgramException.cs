using System;

namespace lab
{
    class InvalidProgramException : Exception
    {
        public InvalidProgramException() { }
        public InvalidProgramException(string message) : base(message) { }
    }
}
