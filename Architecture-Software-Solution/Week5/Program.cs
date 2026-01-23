using MetodologíasDeProgramaciónI;
using System;
using Week5.Command_Pattern;
using Week5.FactoryMethod_Pattern;
using Week5.MyCollections;
using Week5.People;

namespace Week5
{
    class Program
    {
        // Factories: ( 1 MyNumber ) ( 2 Alumno ) ( 3 Professor ) ( 4 DiligentAlumno ) ( 5 AlumnoBaseDecorator ) ( 6 DiligentAlumnoBaseDecorator )

        public static void Main(string[] args)
        {
            //(Clase 5) ejercicio 2: ejecute el main de (Clase 4) Ejercicio 8, implementando a Proxy
            //(Week 5) Exercise 2: Execute the main but using AlumnoProxy

            RandomDataGenerator generator = new RandomDataGenerator();
            Teacher teacher = new Teacher();
            for (int i = 0; i<10; i++)
            {
                teacher.goToClass(new AlumnoAdapter(new AlumnoProxy(generator.RandomString(), 5)));
                teacher.goToClass(new AlumnoAdapter(new AlumnoProxy(generator.RandomString(), 6)));
            }
            teacher.teachingAClass();

            //(Week 5) Exercise 10: Implement a function that instance a Classroom and a queued with orders that has the classroom as receiver

            Classroom classroom = new Classroom();
            MyQueue queued = new MyQueue();

            queued.SetStartCommand(new StartCommand(classroom));
            queued.SetAlumnoArrivalCommand(new AlumnoArrivalCommand(classroom));
            queued.SetFullClassroomCommand(new FullClassroomCommand(classroom));

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