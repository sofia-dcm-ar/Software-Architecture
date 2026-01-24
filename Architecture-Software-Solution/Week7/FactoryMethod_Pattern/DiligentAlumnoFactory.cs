using System;
using Week7.People;

namespace Week7.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Implement the concrete factories
    //(Week 7) Add the Chain of handlers
    public class DiligentAlumnoFactory : MyComparableFactory
    {
        public DiligentAlumnoFactory()
        {
            this.CreateChainOfHandlers();
        }
        public override IMyComparable RandomCreate()
        {
            return new DiligentAlumno(base._chainOfHandlers.RandomString(), base._chainOfHandlers.RandomNumber(50000000), base._chainOfHandlers.RandomNumber(2000), (double)base._chainOfHandlers.RandomNumber(10));
        }

        public override IMyComparable KeyboardCreate()
        {
            Console.Write("Introduce the name: ");
            string name = base._chainOfHandlers.KeyboardString();
            Console.Write("\nIntroduce the ID: ");
            int id = base._chainOfHandlers.KeyboardNumber();
            Console.Write("\nIntroduce the File Number: ");
            int fileNumber = base._chainOfHandlers.KeyboardNumber();
            Console.Write("\nIntroduce the Average: ");
            double average = double.Parse(Console.ReadLine());
            return new DiligentAlumno(name, id, fileNumber, average);
        }

        public override IMyComparable FileCreate()
        {
            return new DiligentAlumno(_chainOfHandlers.StringFromFile(), (int)_chainOfHandlers.NumberFromFile(50000000), (int)_chainOfHandlers.NumberFromFile(2000), _chainOfHandlers.NumberFromFile(10));
        }

    }
}
