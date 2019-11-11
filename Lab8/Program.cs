using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> collectInt = new CollectionType<int>();
            CollectionType<float> collectFloat = new CollectionType<float>();
            CollectionType<string> collectString = new CollectionType<string>();

            collectInt.Add(5);
            collectInt.Add(100);
            collectInt.Add(200);
            collectInt.Delete(1);
            collectInt.Show();
            collectString.Add("qwerty");
            collectString.Add("qwerty1");
            collectString.Delete(3);
            collectString.Show();
            collectFloat.Add(35);
            collectFloat.Add(12);
            collectFloat.Delete(1);
            collectFloat.Show();

            CollectionType<Company> collectCompany = new CollectionType<Company>();

            collectCompany.Add(new Company("Co", 2017, "S"));
            


            Console.ReadKey();
        }
    }
}
