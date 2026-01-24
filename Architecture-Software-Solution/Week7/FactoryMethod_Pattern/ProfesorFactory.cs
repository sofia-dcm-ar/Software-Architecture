using System;

namespace Week7.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Implement the concrete factories
    //(Week 7) Add the Chain of handlers
    public class ProfesorFactory : MyComparableFactory
    {
        public ProfesorFactory()
        {
            this.CreateChainOfHandlers();
        }

        public override IMyComparable RandomCreate()
        {
            return new Professor(base._chainOfHandlers.RandomNumber(), base._chainOfHandlers.RandomString(), base._chainOfHandlers.RandomNumber(50000000));
        }


        public override IMyComparable KeyboardCreate()
        {
            Console.Write("Ingrese el _name: ");
            string name = base._chainOfHandlers.KeyboardString();
            Console.Write("\nIngrese el DNI: ");
            int id = base._chainOfHandlers.KeyboardNumber();
            Console.Write("\nIngrese la antiguedad: ");
            int tenure = base._chainOfHandlers.KeyboardNumber();
            return new Professor(tenure, name, id);
        }

        public override IMyComparable FileCreate()
        {
            return new Professor((int)_chainOfHandlers.NumberFromFile(), _chainOfHandlers.StringFromFile(), (int)_chainOfHandlers.NumberFromFile(50000000));
        }
    }
}
