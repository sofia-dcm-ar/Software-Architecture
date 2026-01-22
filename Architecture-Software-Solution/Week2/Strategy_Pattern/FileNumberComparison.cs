using System;

namespace Week2.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    //Concrete Strategy: FileNumberComparison
    internal class FileNumberComparison : IComparisonStrategy
    {
        public FileNumberComparison() { }

        public bool IsEqual(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetFileNumber() == alumno2.GetFileNumber());
        }

        public bool IsLessThan(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetFileNumber() < alumno2.GetFileNumber());
        }

        public bool IsGreaterThan(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.GetFileNumber() > alumno2.GetFileNumber());
        }
    }
}
