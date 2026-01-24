using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Week7.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Implement the concrete factories
    //(Week 7) Add the Chain of handlers
    public class MyNumberFactory : MyComparableFactory
    {
        public MyNumberFactory()
        {
            this.CreateChainOfHandlers();
        }

        public override IMyComparable RandomCreate()
        {
            return new MyNumber(base._chainOfHandlers.RandomNumber());
        }

        public override IMyComparable KeyboardCreate()
        {
            return new MyNumber(base._chainOfHandlers.KeyboardNumber());
        }

        public override IMyComparable FileCreate()
        {
            return new MyNumber((int)_chainOfHandlers.NumberFromFile());
        }
    }
}
