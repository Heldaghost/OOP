using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    sealed class Cartoon : TVProgram
    {
        public override void ShowProgram()
        {
            Console.WriteLine("Showing cartoon...");
        }
        public override string ToString()
        {
            return "This is a cartoon program";
        }
        public override ProgramType GetProgramType()
        {
            return ProgramType.NotAdv;
        }
    }
}
