using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Advertising : TVProgram
    {
        public override void ShowProgram()
        {
            Console.WriteLine("Showing advertising...");
        }
        public override ProgramType GetProgramType()
        {
            return ProgramType.Adv;
        }
    }
}
