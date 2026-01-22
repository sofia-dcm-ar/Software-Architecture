using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Week3.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Exercise 5.A: Implement with the Factory Method the concrete factories
    // MyNumber Factory
    public class MyNumberFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            return new MyNumber(base._create.RandomNumber());
        }

        public override IMyComparable KeyboardCreate()
        {
            return new MyNumber(base._read.KeyboardNumber());
        }
    }
}
