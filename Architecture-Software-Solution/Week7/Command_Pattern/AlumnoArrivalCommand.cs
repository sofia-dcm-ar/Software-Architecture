using System;
using Week7.People;

namespace Week7.Command_Pattern
{
    //(Week 5) COMMAND -> Exercise 7: Implement a new concrete command of IClassroomCommand2 interface
    public class AlumnoArrivalCommand : IClassroomCommand2
    {
        private Classroom _classroom;
        public AlumnoArrivalCommand(Classroom classroom)
        {
            _classroom = classroom;
        }
        public void Execute(IMyComparable comparable)
        {
            _classroom.AddAlumno((IAlumno)comparable);
        }
    }
}
