using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public struct Copyright
    {
        public string name;
    };
    abstract class TVProgram : IProgram
    {
        int m_duration;
        int m_production;
        string m_name;
        public enum ProgramType
        {
            Undefined=-1,
            NotAdv,
            Adv
        };
      
        
        public Author Author { get; set; }
        public bool ContainsAds { get; set; }
        public Copyright Owner;
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

        public int ProductionYear
        {
            get
            {
                return m_production;
            }
            set
            {
                if (value < 0 || value >2019)
                    m_duration = 0;
                else
                    m_duration = value;
            }
        }

        public override string ToString() => "TVProgram type";

        public abstract void ShowProgram();
    }
}
