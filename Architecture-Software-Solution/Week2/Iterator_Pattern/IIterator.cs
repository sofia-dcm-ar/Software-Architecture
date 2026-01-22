using System;

namespace Week2.Iterator_Pattern
{
    //(Week 2) Exercise 5: Make Stack, Queue and Set classes implement the iterable interface
    // Create the Iterator interface for the concrete iterators
    public interface IIterator
    {
        void First(); // set as current the first element of the collection

        void Next(); // access the next element of the collection

        bool IsDone(); // returns a boolean indicating whether the current element is the last one

        IMyComparable CurrentItem(); // returns the current object, a comparable
    }
}
