using System;

namespace lab
{

    public class InvalidDurationException : Exception
    {
        public InvalidDurationException() { }
        public InvalidDurationException(string message) : base(message) { }
    }

}