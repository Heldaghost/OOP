using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    abstract class Author
    {
        string FirstName { get; set; }
        public string LastName { get; set; }
        public int Trophies { get; set; }

        public abstract void ShowProgram();
        

    }
}
