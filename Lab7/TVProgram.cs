using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    abstract class TVProgram : IProgram
    {
        int m_duration;
        public enum ProgramType
        {
            Adv,
            NotAdv,
            Undefined
        };
        public Author Author { get; set; }
        public bool ContainsAds { get; set; }

        public abstract ProgramType GetProgramType();

        public int Duration
        {
            get
            {
                return m_duration;
            }
            set
            {
                if (value < 0)
                    m_duration = 0;
                else
                    m_duration = value;
            }
        }

        public override string ToString() => "TVProgram type";

        public abstract void ShowProgram();
    }
}
