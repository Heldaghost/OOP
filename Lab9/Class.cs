using System;
namespace OOP_Lab09
{
    public class Class
    {
        public static int time;
        public static int level;
        public static int key;
        public static void Work(int tmp)
        { Console.WriteLine($"User is working {tmp} years");
            time += tmp;
        }

        public static void Upgrade(int tmp)
        { Console.WriteLine("Level upgrated to " + tmp);
            level = tmp;
        }
        
        public static void Key(int tmp)
        {
            Console.WriteLine($"Key for your user is {tmp}");
            key = tmp;
        }
        public static void State(int tmp)
        {
            if (tmp == key)
                Console.WriteLine($"User worked {time} hours and his level is - {level}");
            else
                Console.WriteLine("You enter wrong key!!!");
        }
        public void PrintMassege(string mes) => Console.WriteLine(mes);
    
    }
}
