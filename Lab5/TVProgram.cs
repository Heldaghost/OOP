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
        int hash;
        public Author Author { get; set; }
        public bool ContainsAds { get; set; }
        public int Duration
        {
            get
            {
                return m_duration;
            }
            set
            {
                if (value < 0)
                {
                    m_duration = 0;
                    hash = 0;
                }
                else
                {
                    m_duration = value;
                    hash = value;
                }
            }
        }

        public override string ToString()
        {
            return "TVProgram type";
        }

        public abstract void ShowProgram();
        public bool Equals(object obj)
        {
            TVProgram tmp = obj as TVProgram;
            if (tmp != null)
            {
                if (this.Author == tmp.Author && this.ContainsAds == tmp.ContainsAds && this.Duration == tmp.Duration)
                    return true;
                else
                    return false;
            }

            throw new Exception("Невозможно преобразовать объект к типу TVprogram.");
        }

        public override int GetHashCode()
        {
            return hash;
        }
    }
}
