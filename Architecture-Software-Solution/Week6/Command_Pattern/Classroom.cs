using System;
using MetodologíasDeProgramaciónI;
using Week6.People;


namespace Week6.Command_Pattern
{
    //(Week 5) Exercise 3: implement the Classroom class
    public class Classroom
    {
        private Teacher _teacher;

        public Classroom() { }

        public void Start()
        {
            Console.WriteLine("Classroom is open");
            this._teacher=new Teacher();
        }

        public void AddAlumno(IAlumno alumno)
        {
            this._teacher.goToClass(new AlumnoAdapter(alumno)); 
        }

        public void ReadyClass()
        {
            this._teacher.teachingAClass();
        }
    }
}
