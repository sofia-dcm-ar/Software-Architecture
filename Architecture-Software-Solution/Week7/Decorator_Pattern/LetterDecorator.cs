using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.People;

namespace Week7.Decorator_Pattern
{
    //(Week 4) Exercise 6: Implement the decorator pattern to show califications
    public class LetterDecorator : AlumnoBaseDecorator
    {
        public LetterDecorator(IAlumno alumno) : base(alumno) { }

        public override string ShowCalification()
        {
            string[] score = { "CERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN" };
            return string.Format("{0} ({1})", base.ShowCalification(), score[this.GetCalification()]);
        }
    }
}
