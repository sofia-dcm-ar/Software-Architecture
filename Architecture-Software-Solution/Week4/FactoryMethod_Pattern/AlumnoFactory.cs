using System;

namespace Week4.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Exercise 5.A: Implement with the Factory Method the concrete factories
    // Alumno Factory
    public class AlumnoFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            return new Alumno(base._create.RandomString(), base._create.RandomNumber(50000000), base._create.RandomNumber(2000), (double)base._create.RandomNumber(10));
        }

        public override IMyComparable KeyboardCreate()
        {
            Console.Write("Introduce the Name: ");
            string name = base._read.KeyboardString();
            Console.Write("\nIntroduce the ID: ");
            int id = base._read.KeyboardNumber();
            Console.Write("\nIntroduce the File Number: ");
            int fileNumber = base._read.KeyboardNumber();
            Console.Write("\nIntroduce the Average: ");
            double average = double.Parse(Console.ReadLine());
            return new Alumno(name, id, fileNumber, average);
        }
    }
}
