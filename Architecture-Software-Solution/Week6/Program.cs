using MetodologíasDeProgramaciónI;
using System;
using Week6.MyCollections;
using Week6.Command_Pattern;
using Week6.FactoryMethod_Pattern;

namespace Week6
{
    class Program
    {
        // Factories: ( 1 MyNumber ) ( 2 Alumno ) ( 3 Professor ) ( 4 DiligentAlumno ) ( 5 AlumnoBaseDecorator ) ( 6 DiligentAlumnoBaseDecorator ) ( 7 CompositeAlumno )
        public static void Main(string[] args)
        {

            //(Week 5) Exercise 10: Implement a function that instance a Classroom and a queued with orders that has the classroom as receiver

            Classroom classroom = new Classroom();
            MyQueue queued = new MyQueue();

            queued.SetStartCommand(new StartCommand(classroom));
            queued.SetAlumnoArrivalCommand(new AlumnoArrivalCommand(classroom));
            queued.SetFullClassroomCommand(new FullClassroomCommand(classroom));

            //(Week 6) COMPOSITE -> Add a CompositeAlumno to the queue
            queued.Add(MyComparableFactory.RandomCreate(7));
            Fill(queued, 2);
            Fill(queued, 4);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        public static void Fill(IMyCollection collection, int option)
        {
            for (int i = 0; i<20; i++)
            {
                collection.Add(MyComparableFactory.RandomCreate(option));
            }
        }
    }
}
