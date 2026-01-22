using System;
using Week4.People;

namespace Week4.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for IAlumnos
    //Concrete Strategy: IDComparison
    public class IDComparison : IComparisonStrategy
    {
        public IDComparison() { }
        
        public bool IsEqual(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetId() == alumno2.GetId());
        }

        public bool IsLessThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetId() < alumno2.GetId());
        }

        public bool IsGreaterThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetId() > alumno2.GetId());
        }
    }
}
