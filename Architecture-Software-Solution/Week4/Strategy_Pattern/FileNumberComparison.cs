using System;
using Week4.People;

namespace Week4.Strategy_Pattern
{
    //(Week 2) STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    //Concrete Strategy: FileNumberComparison
    internal class FileNumberComparison : IComparisonStrategy
    {
        public FileNumberComparison() { }

        public bool IsEqual(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetFileNumber() == alumno2.GetFileNumber());
        }

        public bool IsLessThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetFileNumber() < alumno2.GetFileNumber());
        }

        public bool IsGreaterThan(IAlumno alumno1, IAlumno alumno2)
        {
            return (alumno1.GetFileNumber() > alumno2.GetFileNumber());
        }
    }
}
