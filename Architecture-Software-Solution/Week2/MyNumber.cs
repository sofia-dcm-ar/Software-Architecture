using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week2
{
    //Exercise 2: Implement the class MyNumber that implements the IMyComparable interface
    //NOTE: Since an interface is implemented, all elements of IMyComparable must be defined
    //NOTE: in the three methods to be implemented, the received parameter must be cast to MyNumber
    public class MyNumber : IMyComparable
    {
        private readonly int _value;

        public MyNumber(int value)
        {
            _value= value;
        }

        public int GetValue()
        {
            return _value;
        }

        //Interface methods implementation
        public bool IsEqual(IMyComparable comparable)
        {
            return (_value==((MyNumber)comparable)._value);
        }

        public bool IsLessThan(IMyComparable comparable)
        {
            return (_value<((MyNumber)comparable)._value);
        }

        public bool IsGreaterThan(IMyComparable comparable)
        {
            return (_value>((MyNumber)comparable)._value);
        }

        //I teach it to print itself (thanks to problems when using the Report function in main, exercise)
        public override string ToString()
        {
            return (GetValue().ToString());
        }
    }
}
