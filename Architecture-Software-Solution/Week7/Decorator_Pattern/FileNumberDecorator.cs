using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.People;

namespace Week7.Decorator_Pattern
{
    //(Week 4) Exercise 6: Implement the decorator pattern to show califications
    // FileNumberDecorator: Decorator that adds the file number of the student before the calification
    public class FileNumberDecorator : AlumnoBaseDecorator
    {
        public FileNumberDecorator(IAlumno alumno) : base(alumno) { }

        public override string ShowCalification()
        {
            string temp = base.ShowCalification();
            return temp.Insert(temp.IndexOf(' '), string.Format(" ({0}/{1})", this.GetFileNumber(), this.GetCalification()));
        }
    }
}
