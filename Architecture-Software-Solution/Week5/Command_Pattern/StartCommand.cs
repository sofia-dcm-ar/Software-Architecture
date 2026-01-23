using System;

namespace Week5.Command_Pattern
{
    //(Week 5) COMMAND -> Exercise 7: Implement a new concrete command of IClassroomCommand1 interface
    internal class StartCommand : IClassroomCommand1
    {
        private Classroom _classroom;
        public StartCommand(Classroom classroom)
        {
            _classroom = classroom;
        }
        public void Execute()
        {
            _classroom.Start();
        }
    }
}
