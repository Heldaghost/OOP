using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class EmptySequenceException : Exception
    {
        public EmptySequenceException() { }
        public EmptySequenceException(string message) : base(message) { }
    }
}
