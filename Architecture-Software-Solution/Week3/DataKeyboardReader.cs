using System;

namespace Week3
{
    //(Week 3) Exercise 3: Implement a class capable of reading data from keyboard
    public class DataKeyboardReader
    {
        public DataKeyboardReader() { }

        public int KeyboardNumber()
        {
            return (int.Parse(Console.ReadLine()));
        }

        public string KeyboardString()
        {
            return (Console.ReadLine());
        }
    }
}
