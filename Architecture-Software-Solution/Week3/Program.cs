using System;
using Week3.FactoryMethod_Pattern;
using Week3.Iterator_Pattern;
using Week3.Observer_Pattern;
using Week3.MyCollections;

namespace Week3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Factorys: ( 1 MyNumber ) ( 2 Alumno ) ( 3 Professor )

            //(Week 3) Exercise 14: Implement the main
            Professor professor = ((Professor)MyComparableFactory.RandomCreate(3));
            MyStack stacked = new MyStack();
            FillCollection(stacked, 2);

            IIterator iterator = stacked.CreateIterator();
            while (!iterator.IsDone())
            {
                professor.Attach((Alumno)iterator.CurrentItem());
                iterator.Next();
            }

            TeachingClasses(professor);


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        //(Week 3) Exercise 6: Implement a single fill function and a single report function (from class 1)
        public static void FillCollection(IMyCollection collection, int option)
        {
            for (int i = 0; i<20; i++)
            {
                collection.Add(MyComparableFactory.RandomCreate(option));
            }
        }

        public static void Report(IMyCollection collection, int option)
        {
            Console.WriteLine("Number of Items: "+ collection.Count());
            Console.WriteLine("Greaten Element: "+collection.Maximum());
            Console.WriteLine("Lesser Element: "+collection.Minimum());
            IMyComparable comparable = MyComparableFactory.KeyboardCreate(option);
            if (collection.Contains(comparable))
                Console.WriteLine("The read element is in the collection");
            else
                Console.WriteLine("The read element is not in the collection");
        }

        //(Week 3) Exercise 13: Implement the function dictadoDeClases, class testing observer pattern

        public static void TeachingClasses(Professor professor)
        {
            for (int i = 0; i<2; i++)
            {
                professor.SpeakToTheClass();
                professor.WriteInTheBoard();
            }
        }

    }
}