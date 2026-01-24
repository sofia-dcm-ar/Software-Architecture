using System;

namespace Week7
{
    //(Week 1) Exercise 1: Implement the interface representing any object capable of comparing itself to another object of the 'same type'.
    //NOTE: It is assumed that the 'other' object received as a parameter is of the same type as the current object.
    public interface IMyComparable
    {
        bool IsEqual(IMyComparable other);
        //Returns true or false depending on whether the received object is equal to the comparable or not 

        bool IsLessThan(IMyComparable other);
        //Returns true or false depending on whether the received object is smaller than the comparable

        bool IsGreaterThan(IMyComparable other);
        //Returns true or false depending on whether the received object is greater than the comparable
    }
}
