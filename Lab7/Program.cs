using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TVProgram[] programs = new TVProgram[4];

                programs[0] = new Film();
                programs[1] = new Cartoon();
                programs[2] = new News();
                programs[3] = new Advertising();

                programs[0].Duration = 4;
                programs[1].Duration = 6;
                programs[2].Duration = 3;
                programs[3].Duration = 200;
                for (int k = 0;k<4;k++) 
                {
                    Debug.Assert(programs[k].Duration != 0, "Duration cannot be 0!");
                }


                ProgramSequence seq = new ProgramSequence();

                foreach (TVProgram program in programs)
                {
                    seq.addProgram(program);
                }

                Console.WriteLine($"Full program length is {seq.Duration}");
                Console.WriteLine($"The number of advertising is {seq.Ads}");
            }
            catch(InvalidProgramException e)
            {
                Console.WriteLine("Catched InvalidProgramException");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            catch(InvalidDurationException e)
            {
                Console.WriteLine("Catched InvalidDurationException");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            catch(EmptySequenceException e)
            {
                Console.WriteLine("Catched EmptySequenceException");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Catched IndexOutOfRangeException");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Catched DivideByZeroException");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally called");
            }
        }
    }
}
