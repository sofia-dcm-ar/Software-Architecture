using System;
using Week7.People;

namespace Week7.Strategy_Pattern
{

    //(Week 2)  STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    public interface IComparisonStrategy
    {
        bool IsEqual(IAlumno a, IAlumno b);
        bool IsLessThan(IAlumno a, IAlumno b);
        bool IsGreaterThan(IAlumno a, IAlumno b);
    }
}
