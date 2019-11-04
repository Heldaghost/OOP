using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    partial class ProgramSequence
    {
        public static ProgramSequence operator + (ProgramSequence seq, TVProgram program)
        {
            seq.addProgram(program);
            return seq;
        }
    }
}
