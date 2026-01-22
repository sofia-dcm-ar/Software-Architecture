using System;

namespace Week2.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    //Concrete Strategy: IDComparison
    public class IDComparison : IComparisonStrategy
    {
        public IDComparison() { }
        
        public bool IsEqual(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetId() == alumno2.GetId());
        }

        public bool IsLessThan(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetId() < alumno2.GetId());
        }

        public bool IsGreaterThan(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetId() > alumno2.GetId());
        }
    }
}
