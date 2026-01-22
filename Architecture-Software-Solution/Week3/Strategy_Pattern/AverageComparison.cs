using System;

namespace Week3.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    //Concrete Strategy: AverageComparison
    public class AverageComparison : IComparisonStrategy
    {
        public AverageComparison() { }

        public bool IsEqual(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetAverage() == alumno2.GetAverage());
        }
        public bool IsLessThan(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetAverage() < alumno2.GetAverage());
        }
        public bool IsGreaterThan(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetAverage() > alumno2.GetAverage());
        }
    }
}
