using System;

namespace Week1
{
    //Exercise 3: Implement interface of a collection of comparable elements.
    public interface IMyCollection
    {
        int Count();
        //Returns the number of comparable elements that the collection has
        //Specific name requestes for the professor to difference between Count() and Count property

        IMyComparable Minimum();
        //Returns the smallest element in the collection

        IMyComparable Maximum();
        //Returns the largest element in the collection

        void Add(IMyComparable comparable);
        //Adds the received comparable to the collection

        bool Contains(IMyComparable comparable);
        //Returns true or false depending on whether the collection contains the received comparable
    }
}
