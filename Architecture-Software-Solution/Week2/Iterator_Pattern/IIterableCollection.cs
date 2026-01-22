using System;

namespace Week2.Iterator_Pattern
{
    public interface IIterableCollection
    {
        //(Week 2) Exercise 5: Make Stack, Queue and Set classes implement the iterable interface
        // This method creates and returns an iterator for the collection
        IIterator CreateIterator();
    }
}
