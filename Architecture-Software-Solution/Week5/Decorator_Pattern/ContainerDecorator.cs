using System;
using Week5.People;

namespace Week5.Decorator_Pattern
{
    //(Week 4) Exercise 6: Implement the decorator pattern to show califications
    //Container Decorator: Adds a box around the calification
    public class ContainerDecorator : AlumnoBaseDecorator
    {
        public ContainerDecorator(IAlumno alumno) : base(alumno) { }

        public override string ShowCalification()
        {
            string text = string.Format("*     {0}     *", base.ShowCalification());
            string box = new string('*', text.Length);
            return string.Format("{0}\n{1}\n{2}", box, text, box);
        }
    }
}
