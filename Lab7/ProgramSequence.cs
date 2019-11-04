using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab
{
    partial class ProgramSequence
    {
        private List<TVProgram> m_programList;
        private List<TVProgram> m_programList1;
        private int m_duration;
        private int m_ads;
        public ProgramSequence()
        {
            m_programList = new List<TVProgram>();
            m_programList1 = new List<TVProgram>();
        }
        public void addProgram(TVProgram program)
        {
            Debug.Assert(program != null);
            m_programList.Add(program);
            m_duration += program.Duration;
            if (m_duration >= 24 * 3600)
                throw new InvalidDurationException();
            if (program is Advertising)
                ++m_ads;
            else if (!(program is TVProgram))
                throw new InvalidProgramException();
        }
        public void removeProgram(int index)
        {
            TVProgram prog = m_programList.ElementAt(index);
            m_duration -= prog.Duration;
            if (prog is Advertising)
                --m_ads;
            m_programList.RemoveAt(index);
        }
        public int Ads
        {
            get
            {
                return m_ads;
            }
        }
        public int Duration
        {
            get
            {
                if (m_duration == 0)
                    throw new EmptySequenceException();
                return m_duration;
            }
        }
    }
}
