using System;


namespace Week7.Command_Pattern
{
    //(WEEK 5) COMMAND -> Interface for those classes that are gonna be commanded
    public interface IOrderable
    {
        void SetStartCommand(IClassroomCommand1 command);
        void SetAlumnoArrivalCommand(IClassroomCommand2 command);
        void SetFullClassroomCommand(IClassroomCommand1 command);
    }
}
