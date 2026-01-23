using System;

namespace Week6.Command_Pattern
{
    //(Week 5) COMMAND -> Exercise 7: Implement a new concrete command of IClassroomCommand1 interface
    internal class FullClassroomCommand : IClassroomCommand1
    {
        private Classroom _classroom;
        public FullClassroomCommand(Classroom classroom)
        {
            _classroom = classroom;
        }
        public void Execute()
        {
            _classroom.ReadyClass();
        }
    }
}
