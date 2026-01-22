using System;

namespace Week4.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Exercise 5.A: Implement with the Factory Method the concrete factories
    // Profesor Factory
    public class ProfesorFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            return new Professor(base._create.RandomNumber(), base._create.RandomString(), base._create.RandomNumber(50000000));
        }


        public override IMyComparable KeyboardCreate()
        {
            Console.Write("Ingrese el nombre: ");
            string name = base._read.KeyboardString();
            Console.Write("\nIngrese el DNI: ");
            int id = base._read.KeyboardNumber();
            Console.Write("\nIngrese la antiguedad: ");
            int tenure = base._read.KeyboardNumber();
            return new Professor(tenure, name, id);
        }
    }
}
