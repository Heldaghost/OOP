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
            TVProgram[] programs = new TVProgram[5];

            programs[0] = new Film();
            programs[1] = new Cartoon();
            programs[2] = new News();
            programs[3] = new Advertising();
            programs[4] = new Advertising();

            programs[0].Duration = 5;
            programs[0].ProductionYear = 2000;
            programs[1].Duration = 6;
            programs[1].ProductionYear = 2011;
            programs[2].Duration = 3;
            programs[2].ProductionYear = 2005;
            programs[3].Duration = 2;
            programs[3].ProductionYear = 1986;
            programs[4].Duration = 5;
            programs[4].ProductionYear = 2013;
            programs[4].Owner.name = "Sasha";

            ProgramSequence seq = new ProgramSequence();

            foreach (TVProgram program in programs)
            {
                seq.addProgram(program);
            }

            Console.WriteLine($"Full program length is {seq.Duration}");
            Console.WriteLine($"The number of advertising is {seq.Ads}");
            Console.WriteLine($"Number of program with some year of production is {seq.ProdYear(2000)}");
        }
    }
}
