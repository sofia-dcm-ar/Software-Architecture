using System;
using Week1.MyCollections;

namespace Week1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Exercise 7: implement a main module where a stack and a queue are created, filled and reported using the report function
            //Exercise 9: modify main to include MultipleCollection
            //Exercise 14: modify main, now instead of filling, we fill the collections with students

            MyStack stacked = new MyStack();
            MyQueue queued = new MyQueue();
            MultipleCollection multiple = new MultipleCollection(stacked, queued);


            FillAlumnos(stacked);
            Console.WriteLine("MyStack filled");
            FillAlumnos(queued);
            Console.WriteLine("MyQueue filled");

            Report(multiple);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        //-------------------Functions---------------------

        //Exercise 5: Implement a fill function that receives a collection and adds 20 random comparables
        public static void Fill(IMyCollection collection)
        {
            Random r = new Random();
            for (int i = 0; i<20; i++)
            {
                IMyComparable c = (IMyComparable)new MyNumber(r.Next(1, 30));
                collection.Add(c);
            }
        }

        //Exercise 6: Implement an inform function that receives an IMyCollection and prints to console:
        //The amount of elements in the IMyCollection received as parameter, the minimum element, the maximum and if it contains, or not, as an element a value read by keyboard.
        public static void Report(IMyCollection collection)
        {
            Console.WriteLine(collection.Count());
            Console.WriteLine("\nYounger Student\n"); //Flag for debugging
            Console.WriteLine(collection.Minimum().ToString()); //need to teach every IMyComparable child how to print themselves
            Console.WriteLine("\nOlder Student\n");
            Console.WriteLine(collection.Maximum().ToString());

            //Exercise 15: search for an student by their record number
            Console.Write("introduce the number of the student Record:"); 
            int search = int.Parse(Console.ReadLine());
            IMyComparable newOne = new Alumno("nombre", 1, search, 1); //change MyNumber for Alumno because now we fill with students , Excercise 14
            if (collection.Contains(newOne))
                Console.WriteLine("The read element is in the collection");
            else
                Console.WriteLine("The read element is not in the collection");
        }


        //Exercise 13: Implement fillStudents function, receives an IMyCollection and adds 20 random students
        public static void FillAlumnos (IMyCollection collection)
        {
            Random r = new Random();
            string[] names = new string[] { "Johnny", "Simon", "John", "Kyle", "Alejandro", "Joel", "Arthur", "Leon", "Valeria", "Kate", "Farah", "Sarah", "Ada", "Helena", "Alice" };
            for (int i = 0; i<20; i++)
            {
                IMyComparable student = new Alumno(names[r.Next(names.Length-1)], r.Next(10000000, 50000000), r.Next(10000, 70000), r.NextDouble());
                collection.Add(student);
            }
        }
    }

}
