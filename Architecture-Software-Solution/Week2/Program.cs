using System;
using Week2.MyCollections;
using Week2.Iterator_Pattern;
using Week2.Strategy_Pattern;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Week 1) Exercise 7: implement a main module where a stack and a queue are created, filled and reported using the report function
            //(Week 1) Exercise 9: modify main to include MultipleCollection
            //(Week 1) Exercise 14: modify main, now instead of filling, we fill the collections with students

            //(Week 2) ITERATOR -> Exercise 7: modify main to use printElements
            //(Week 2) STRATEGY -> Exercise 9: modify main to change comparison strategy of the elements


            MyQueue queued = new MyQueue();
            FillAlumnos(queued);
            Console.WriteLine("Comparison for Name\n");
            ChangeComparisonStrategy(queued, new NameComparison());
            Report(queued);
            Console.WriteLine("\nComparison for File Number\n");
            ChangeComparisonStrategy(queued, new FileNumberComparison());
            Report(queued);
            Console.WriteLine("\nComparison for Average\n");
            ChangeComparisonStrategy(queued, new AverageComparison());
            Report(queued);
            Console.WriteLine("Comparison for ID\n");
            ChangeComparisonStrategy(queued, new IDComparison());
            Report(queued);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        //-------------------Functions---------------------

        public static void Report(IMyCollection collection)
        {
            Console.WriteLine(collection.Count());
            Console.WriteLine("\nYounger Student\n"); //Flag for debugging
            Console.WriteLine(collection.Minimum().ToString()); //need to teach every IMyComparable child how to print themselves
            Console.WriteLine("\nOrder Student\n");
            Console.WriteLine(collection.Maximum().ToString());
            Console.Write("Introduce information for search:");
            string search = Console.ReadLine();
            double searchNumber = 0;
            double.TryParse(search, out searchNumber); 
            IMyComparable searched = new Alumno(search, (int)searchNumber, (int)searchNumber, searchNumber); 
            if (collection.Contains(searched))
                Console.WriteLine("The read element is in the collection");
            else
                Console.WriteLine("The read element isn't in the collection");
        }

        //(Week 1) Exercise 13: Implement fillStudents function, receives an IMyCollection and adds 20 random students
        //(Week 2) STRATEGY -> Exercise 2: Modify the fillStudents function so that it can set a comparison strategy
        public static void FillAlumnos(IMyCollection collection)
        {
            Random r = new Random();
            FileNumberComparison comparison = new FileNumberComparison();
            string[] names = new string[] { "Johnny", "Simon", "John", "Kyle", "Alejandro", "Joel", "Leon", "Valeria", "Katherine", "Farah", "Sarah", "Ada", "Helena", "Alice" };
            for (int i = 0; i<20; i++)
            {
                double prom = double.Parse(r.NextDouble().ToString("F2")); //Para que sean solo dos cifras significativas
                IMyComparable student = new Alumno(names[r.Next(names.Length-1)], r.Next(10000000, 50000000), r.Next(10000, 70000), prom);
                ((Alumno)student).SetStrategy(comparison);
                collection.Add(student);
            }
        }

        //(Week 2) ITERATOR -> Exercise 6: Immplement a function that receives an IMyCollection and prints all its elements using its iterator
        public static void PrintElements(IMyCollection collection)
        {
            IIterator concreteIterator = collection.CreateIterator();
            concreteIterator.First();
            while (!concreteIterator.IsDone())
            {
                Console.WriteLine(concreteIterator.CurrentItem());
                concreteIterator.Next();
            }

        }

        //(Week 2) Exercise 8: Immplement a function that receives an IMyCollection and a comparison strategy, and changes the comparison strategy of all the elements in the collection

        public static void ChangeComparisonStrategy(IMyCollection collection, IComparisonStrategy newStrategy)
        {
            IIterator concreteIterator = collection.CreateIterator();
            while (!concreteIterator.IsDone())
            {
                ((Alumno)concreteIterator.CurrentItem()).SetStrategy(newStrategy);
                concreteIterator.Next();
            }
        }
    }
}
