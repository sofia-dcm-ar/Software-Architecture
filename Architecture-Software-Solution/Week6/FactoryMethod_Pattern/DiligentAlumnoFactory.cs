using System;
using Week6.People;

namespace Week6.FactoryMethod_Pattern
{
    public class DiligentAlumnoFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            return new DiligentAlumno(base._create.RandomString(), base._create.RandomNumber(50000000), base._create.RandomNumber(2000), (double)base._create.RandomNumber(10));
        }

        public override IMyComparable KeyboardCreate()
        {
            Console.Write("Introduce the name: ");
            string name = base._read.KeyboardString();
            Console.Write("\nIntroduce the ID: ");
            int id = base._read.KeyboardNumber();
            Console.Write("\nIntroduce the File Number: ");
            int fileNumber = base._read.KeyboardNumber();
            Console.Write("\nIntroduce the Average: ");
            double average = double.Parse(Console.ReadLine());
            return new DiligentAlumno(name, id, fileNumber, average);
        }
    }
}
