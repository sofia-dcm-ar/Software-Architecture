using System;

namespace Week7.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Implement the concrete factories
    //(Week 7) Add the Chain of handlers
    public class AlumnoFactory : MyComparableFactory
    {
        public AlumnoFactory()
        {
            this.CreateChainOfHandlers();
        }

        public override IMyComparable RandomCreate()
        {
            return new Alumno(base._chainOfHandlers.RandomString(), base._chainOfHandlers.RandomNumber(50000000), base._chainOfHandlers.RandomNumber(2000), (double)base._chainOfHandlers.RandomNumber(10));
        }

        public override IMyComparable KeyboardCreate()
        {
            Console.Write("Introduce the Name: ");
            string name = base._chainOfHandlers.KeyboardString();
            Console.Write("\nIntroduce the ID: ");
            int id = base._chainOfHandlers.KeyboardNumber();
            Console.Write("\nIntroduce the File Number: ");
            int fileNumber = base._chainOfHandlers.KeyboardNumber();
            Console.Write("\nIntroduce the Average: ");
            double average = double.Parse(Console.ReadLine());
            return new Alumno(name, id, fileNumber, average);
        }

        public override IMyComparable FileCreate()
        {
            return new Alumno(_chainOfHandlers.StringFromFile(), (int)_chainOfHandlers.NumberFromFile(50000000), (int)_chainOfHandlers.NumberFromFile(2000), _chainOfHandlers.NumberFromFile(10));
        }
    }
}
