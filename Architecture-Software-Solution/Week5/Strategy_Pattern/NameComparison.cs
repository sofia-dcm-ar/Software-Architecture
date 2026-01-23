using System;
using Week5.People;

namespace Week5.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for IAlumnos
    //Concrete Strategy: Name Comparison
    public class NameComparison : IComparisonStrategy
    {
        public NameComparison() { }

        public bool IsEqual(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetName() == alumno2.GetName());
        }
        public bool IsLessThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (String.Compare(alumno1.GetName().ToUpper(), alumno2.GetName().ToUpper()) <= -1);
        }
        public bool IsGreaterThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (String.Compare(alumno1.GetName().ToUpper(), alumno2.GetName().ToUpper()) > 0);
        }
    }
}
