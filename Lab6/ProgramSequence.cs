using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    partial class ProgramSequence
    {
        private List<TVProgram> m_programList;
        private int m_duration;
        private int m_ads;
        private int m_production;
        public ProgramSequence()
        {
            m_programList = new List<TVProgram>();
        }
        public void addProgram(TVProgram program)
        {
            m_programList.Add(program);
            m_duration += program.Duration;
            if (program is Advertising)
                ++m_ads;
            m_production = program.ProductionYear;
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
                return m_duration;
            }
        }

    }
}
