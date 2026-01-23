using System;
using Week5.People;

namespace Week5.Strategy_Pattern
{

    //(Week 2)  STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    public interface IComparisonStrategy
    {
        bool IsEqual(IAlumno a, IAlumno b);
        bool IsLessThan(IAlumno a, IAlumno b);
        bool IsGreaterThan(IAlumno a, IAlumno b);
    }
}
