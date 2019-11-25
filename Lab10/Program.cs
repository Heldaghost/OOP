using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _10lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 5; ++i)
                arrayList.Add(random.Next());
            arrayList.Add("string");
            arrayList.Add(new Student());
            arrayList.RemoveAt(2);
            Console.WriteLine($"size = {arrayList.Count}");
            foreach (object obj in arrayList)
                Console.WriteLine(obj);
            Console.WriteLine($"search for string result = {arrayList.IndexOf("string")}");
            // Generic collection
            SortedList<long, long> genericCollection = new SortedList<long, long>();
            for(int i = 0; i < 10; ++i)
                genericCollection.Add(i, random.Next());
            Console.WriteLine("Generic collection:");
            for (int i = 1; i < 3; i++)
                genericCollection.Remove(i);
            foreach (KeyValuePair<long, long> item in genericCollection)
                Console.WriteLine(item);
            Stack<long> secondGenericCollection = new Stack<long>();
            foreach (KeyValuePair<long, long> item in genericCollection)
                secondGenericCollection.Push(item.Value);
            SortedList<int, Student> ObGenericCollection = new SortedList<int, Student>();
            for (int i = 0; i < 5; ++i)
                ObGenericCollection.Add(i, new Student());
            Stack < Student > ObStack = new Stack<Student>();
            foreach (KeyValuePair<int, Student> item in ObGenericCollection)
            {
                Console.WriteLine(item);
                ObStack.Push(item.Value);
            }
            foreach (Student item in ObStack)
                Console.WriteLine(item);
            ObservableCollection<int> obs = new ObservableCollection<int>();
            obs.CollectionChanged += Ch;
            obs.Add(5);
            obs.Remove(5);
            
        }
        public static void Ch(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection changed");
        }
    }
}
