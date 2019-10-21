using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Triller : Author, IProgram
    {
        public override void ShowProgram()
        {
            Console.WriteLine("Showing from Author");
        }

        void IProgram.ShowProgram()
          {
            Console.WriteLine("Shownig from IProgram");
          }
        public Author Author { get; set; }
        public bool ContainsAds { get; set; }
        public int Duration
        {
            get; set;
        }
    }
}
