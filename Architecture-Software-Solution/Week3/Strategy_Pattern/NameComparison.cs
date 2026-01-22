using System;

namespace Week3.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    //Concrete Strategy: Name Comparison
    public class NameComparison : IComparisonStrategy
    {
        public NameComparison() { }

        public bool IsEqual(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetName() == alumno2.GetName());
        }
        public bool IsLessThan(Alumno alumno1, Alumno alumno2)
        {
            return (String.Compare(alumno1.GetName().ToUpper(), alumno2.GetName().ToUpper()) <= -1);
        }
        public bool IsGreaterThan(Alumno alumno1, Alumno alumno2)
        {
            return (String.Compare(alumno1.GetName().ToUpper(), alumno2.GetName().ToUpper()) > 0);
        }
    }
}
