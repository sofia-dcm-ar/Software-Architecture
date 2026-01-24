using MetodologíasDeProgramaciónI;
using System;
using Week7.MyCollections;
using Week7.Command_Pattern;
using Week7.FactoryMethod_Pattern;

namespace Week7
{
    class Program
    {
        // Factories: ( 1 MyNumber ) ( 2 Alumno ) ( 3 Professor ) ( 4 DiligentAlumno ) ( 5 AlumnoBaseDecorator ) ( 6 DiligentAlumnoBaseDecorator ) ( 7 CompositeAlumno )
        public static void Main(string[] args)
        {

            Classroom classroom = new Classroom();
            MyQueue queued = new MyQueue();

            queued.SetStartCommand(new StartCommand(classroom));
            queued.SetAlumnoArrivalCommand(new AlumnoArrivalCommand(classroom));
            queued.SetFullClassroomCommand(new FullClassroomCommand(classroom));

            //(Week 7) Add a specific amount of Alumnos of different types

            // 2 DiligentAlumnoBaseDecorator from keyboard
            FillKeyboard(queued, 6, 2);
            // 5 AlumnoProxy inside 1 composite from file
            FillFile(queued, 7, 1);
            // The rest 33 for fill the classroom, all random
            FillRandom(queued, 5, 37);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        public static void FillRandom(IMyCollection collection, int option,int amount)
        {
            for (int i = 0; i<amount; i++)
            {
                collection.Add(MyComparableFactory.RandomCreate(option));
            }
        }
        public static void FillFile(IMyCollection collection, int option, int amount)
        {
            for (int i = 0; i<amount; i++)
            {
                collection.Add(MyComparableFactory.FileCreate(option));
            }
        }

        public static void FillKeyboard(IMyCollection collection, int option, int amount)
        {
            for (int i = 0; i<amount; i++)
            {
                collection.Add(MyComparableFactory.KeyboardCreate(option));
            }
        }
    }
}
