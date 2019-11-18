using System;

namespace OOP_Lab09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var c = new Class(); 

            User Alex = new User();
            Alex.AddEvent += Class.Key;
            Alex.AddEvent += Class.Work;
            Alex.AddEvent += Class.Upgrade;
            Alex.AddEvent += Class.State;
            Console.WriteLine("Enter a key for User:");
            string tmp = Console.ReadLine();
            Alex.Key(Convert.ToInt32(tmp));
            Alex.Work(10);
            Alex.Upgrade(2);
            Alex.Work(15);
            Console.WriteLine("Enter a key to see state");
            tmp = Console.ReadLine();
            Alex.State(Convert.ToInt32(tmp));
            
         

            Alex.MesEvent += (message) => Console.WriteLine(message);

            Alex.CallEvents(User.CALL_MESSAGE_EVENT,1,"WORKING");


            string str = "Hello! Ohhh , this is some string...";
            Action<string> actionOnConsole = (s) => Console.WriteLine(s);
            actionOnConsole(str);

            Func<string, string> func = User.AddSymbols;
            actionOnConsole(str = func(str));
            func += User.ToUpperCase;
            actionOnConsole(str = func(str));

            func += User.AfterFirstWord;
            actionOnConsole(str = func(str));

            func += User.RemoveSpaces;
            actionOnConsole(str = func(str));

            func += User.RemoveCommasDotes;
            actionOnConsole(str = func(str));
            
        }
    }
}
