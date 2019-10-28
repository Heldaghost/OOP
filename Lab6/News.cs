using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    sealed class News : TVProgram
    {
        public override void ShowProgram()
        {
            Console.WriteLine("Showing news...");
        }

        public override string ToString()
        {
            return "This is a news program";
        }

        public override ProgramType GetProgramType()
        {
            return ProgramType.NotAdv;
        }
    }
}
