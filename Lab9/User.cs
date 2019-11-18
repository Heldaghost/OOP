using System;
namespace OOP_Lab09
{
    public class User
    {
        public const int CALL_ADD_EVENT = 0;
        public const int CALL_MESSAGE_EVENT = 1;

        public delegate void Add(int number);
        public event Add AddEvent;

        public delegate void Mes(string mes);
        public event Mes MesEvent;
        public Add Work = Class.Work;
        public Add Upgrade = Class.Upgrade;
        public Add Key = Class.Key;
        public Add State = Class.State;

        private int Level { get; set; }

        public void CallEvents(int eventConst, int value = 0, string mes = "")
        {
            switch (eventConst)
            {
                case CALL_ADD_EVENT:
                    {
                        AddEvent(value);
                        break;
                    }
                case CALL_MESSAGE_EVENT:
                    {
                        MesEvent(mes);
                        break;
                    }
            }
        }


        public static string RemoveCommasDotes(string str)
        {
            string result = "";
            foreach (char ch in str)
            {
                if (ch == ',' || ch == '.')
                    continue;
                result += ch;
            }
            return result;
        }

        public static string AddSymbols(string str)
        {
            string result = "!";
            result = result + str + result;
            return result;
        }

        public static string ToUpperCase(string str) => str.ToUpper();

        public static string RemoveSpaces(string str)
        {
            string result = "";
            foreach (char ch in str)
            {
                if (ch == ' ')
                    continue;
                result += ch;
            }
            return result;
        }

        public static string AfterFirstWord(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                {
                    result = str.Substring(i);
                    break;
                }
            return result;
        }

    }
}