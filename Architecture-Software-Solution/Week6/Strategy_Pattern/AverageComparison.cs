using System;
using Week6.People;

namespace Week6.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for IAlumnos
    //Concrete Strategy: AverageComparison
    public class AverageComparison : IComparisonStrategy
    {
        public AverageComparison() { }

        public bool IsEqual(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetAverage() == alumno2.GetAverage());
        }
        public bool IsLessThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetAverage() < alumno2.GetAverage());
        }
        public bool IsGreaterThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetAverage() > alumno2.GetAverage());
        }
    }
}
