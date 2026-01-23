using System;
using Week5.People;

namespace Week5.Decorator_Pattern
{
    public class StatusDecorator : AlumnoBaseDecorator
    {
        //(Week 4) Exercise 6: Implement the decorator pattern to show califications
        // Status Decorator: Adds the status of the grade "Promoted, Passed, Failed"
        public StatusDecorator(IAlumno alumno) : base(alumno) { }

        public override string ShowCalification()
        {
            string status;
            int calification = this.GetCalification();
            if (calification>=7)
                status = "PROMOTED";
            else if ((7>calification)&&(calification>=4))
                status = "PASSED";
            else
                status = "FAILED";
            return string.Format("{0} ({1})", base.ShowCalification(), status);
        }
    }
}
