using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Film : TVProgram
    {
       
        public override void ShowProgram()
        {
            Console.WriteLine("Showing film...");
        }

        public override string ToString()
        {
            return "This is a film program";
        }
    }
}
