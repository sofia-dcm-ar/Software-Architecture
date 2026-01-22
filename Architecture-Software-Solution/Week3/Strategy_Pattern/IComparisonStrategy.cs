using System;

namespace Week3.Strategy_Pattern
{

    //(Week 2)  STRATEGY -> Exercise 1:Implement four comparison strategies for Alumnos
    public interface IComparisonStrategy
    {
        bool IsEqual(Alumno a, Alumno b);
        bool IsLessThan(Alumno a, Alumno b);
        bool IsGreaterThan(Alumno a, Alumno b);
    }
}
