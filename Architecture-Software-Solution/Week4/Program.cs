using MetodologíasDeProgramaciónI;
using Microsoft.VisualBasic.FileIO;
using System;
using Week4.Decorator_Pattern;
using Week4.FactoryMethod_Pattern;
using Week4.MyCollections;
using Week4.People;

namespace Week4
{
    class Program
    {
        // Factories: ( 1 MyNumber ) ( 2 Alumno ) ( 3 Professor ) ( 4 DiligentAlumno ) ( 5 AlumnoBaseDecorator ) ( 6 DiligentAlumnoBaseDecorator )

        public static void Main(string[] args)
        {
            //(Week 4) Exercise 4: Implement a main function that instantiates a teacher, makes 20 students arrive with the GoToClass method
            //The Students are instances of the adapter implemented in the previous exercise.
            //10 of them will adapt an instance of the Alumno class, while another 10 will adapt DiligentAlumno

            //(Week 4) Exercise 7: Build the decorated students

            Teacher teacher = new Teacher();
            for (int i = 0; i<10; i++)
            {
                teacher.goToClass(new AlumnoAdapter((AlumnoBaseDecorator)MyComparableFactory.RandomCreate(5)));
                teacher.goToClass(new AlumnoAdapter((AlumnoBaseDecorator)MyComparableFactory.RandomCreate(6)));
            }
            teacher.teachingAClass();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        //-------------------Functions---------------------
        public static void Fill(IMyCollection collection, int option)
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