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

        public int ProdYear(int year)
        {
            int index = 0;
            int tmp = 1;
            foreach (TVProgram program in m_programList)
            {
                index++;
                if (year == program.ProductionYear)
                    tmp = index;
            }
            return tmp;
        }
    }
}
