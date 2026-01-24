using System;

namespace Week7.ChainOfResponsability_Pattern
{
    //(Week 3) Exercise 3: Implement a class capable of reading data from keyboard
    //(Week 7) Implemment the singletone pattern
    //(week 7) CHAIN OF RESPONSABILITY -> Make the Data keyboard reader a handler 
    public class DataKeyboardReader : BaseHandler
    {
        private static DataKeyboardReader _instance = null;
        public DataKeyboardReader(BaseHandler handler) : base(handler) { }

        public override int KeyboardNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        public override string KeyboardString()
        {
            return Console.ReadLine();
        }

        public static DataKeyboardReader GetInstance(BaseHandler handler)
        {
            if (_instance==null)
                _instance = new DataKeyboardReader(handler);
            return _instance;
        }
    }
}
