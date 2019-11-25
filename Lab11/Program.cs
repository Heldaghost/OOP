using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_Lab11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1 ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
            string[] linqArray = { "January", "February", "Martch", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            var lenSelected = from item in linqArray
                                where item.Length == 4
                                select item;

            foreach (string item in lenSelected)
                Console.WriteLine(item);
            Console.WriteLine("Length == 4 =============================");



            var sesonSelected = from item in linqArray
                                    where item.Equals("June") || item.Equals("July") || item.Equals("August") || item.Equals("December") ||item.Equals("January") || item.Equals("February")
                                    select item;

            foreach (string item in sesonSelected)
                Console.WriteLine(item);
            Console.WriteLine("sesonSelected=============================");



            var alphabetSelected = from item in linqArray
                                   orderby item
                                   select item;

            foreach (string item in alphabetSelected)
                Console.WriteLine(item);
            Console.WriteLine("alphabetSelected=============================");



            var singSelected = from item in linqArray
                                where item.Contains("u") || item.Length > 4
                                select item;

            foreach (string item in singSelected)
                Console.WriteLine(item);
            Console.WriteLine("singSelected=============================");
            // 2 ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            List<Time> timeList = new List<Time>();
            timeList.Add(new Time(5,0,0));
            timeList.Add(new Time(13, 15));
            timeList.Add(new Time(18, 59));
            timeList.Add(new Time(7, 10, 38));


            List<Time> timeList1 = new List<Time>();
            timeList1.Add(new Time(5, 0, 0));
            timeList1.Add(new Time(14, 15));
            timeList1.Add(new Time(19, 59));
            timeList1.Add(new Time(7, 10, 38));

            var hourSelected = from item in timeList
                                      where item.Hour == 5
                                      select item;

            foreach (Time item in hourSelected)
            {
                Console.WriteLine(timeList.IndexOf(item));
            
            }


            Console.WriteLine("Hour == 5=============================");

            var morningSelected = from item in timeList
                                  where (item.Hour > 4 || item.Hour < 10)
                                  select item;
            foreach (Time item in morningSelected)
            {
                Console.WriteLine(timeList.IndexOf(item));

            }

            Console.WriteLine("item.Hour > 4 || item.Hour < 10=============================");

            // проекция
            var seconds = from item in timeList
                          where item.Second != 0
                          select item;

            foreach (Time item in seconds)
            {
                Console.WriteLine(timeList.IndexOf(item));

            }
            Console.WriteLine("item.Second != 0=============================");

            var anySelected = timeList.Any(item => item.Hour == 5);
            Console.WriteLine(anySelected);

            Console.WriteLine("Any=============================");

            var allSelected = timeList.All(item => item.Minute == 30);
            Console.WriteLine(allSelected);

            Console.WriteLine("All=============================");

            var averageTime = timeList.Average(item => item.Hour);
            Console.WriteLine(averageTime);

            Console.WriteLine("Average=============================");

            var joinList = from item in timeList
                           join hours in timeList1 on item.Hour equals hours.Hour
                           select item;

            foreach (Time item in joinList)
            {
                Console.WriteLine(timeList.IndexOf(item));
            }
            Console.WriteLine("Join==================================");
        }
    }
}
