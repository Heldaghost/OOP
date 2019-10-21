using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            TVProgram[] programs = new TVProgram[3];

            programs[0] = new Film();
            programs[1] = new Cartoon();
            programs[2] = new News();

            Triller triller = new Triller();
            triller.ShowProgram();
            ((IProgram)triller).ShowProgram();

            foreach (TVProgram program in programs)
            {
                Printer.iAmPrinting(program);
                program.ShowProgram();
            }
        }
    }
}
