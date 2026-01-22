using System;
using Week2.Iterator_Pattern;

namespace Week2
{
    //(Week 1) Excercise 8: Create a class Collection that implements IMyCollection by combining a stack and a queue 
    public class MultipleCollection : IMyCollection
    {
        private readonly MyStack _stacked;
        private readonly MyQueue _queued;

        public MultipleCollection(MyStack stack, MyQueue queue)
        {
            this._stacked=new MyStack();
            this._stacked=stack;
            this._queued=new MyQueue();
            this._queued=queue;
        }

        //Interface methods implementation
        public int Count()
        { 
            //return how many elements are in total in both collections
            return _stacked.Count()+_queued.Count();
        }

        public IMyComparable Minimum()
        { 
            //returns the element of lesser value between both collections
            IMyComparable toCompare1 = _stacked.Minimum();
            IMyComparable toCompare2 = _queued.Minimum();
            if (toCompare1.IsLessThan(toCompare2))
                return toCompare1;
            return toCompare2;
        }

        public IMyComparable Maximum()
        {
            //returns the element of greater value between both collections
            IMyComparable toCompare1 = _stacked.Maximum();
            IMyComparable toCompare2 = _queued.Maximum();
            if (toCompare1.IsGreaterThan(toCompare2))
                return toCompare1;
            return toCompare2;
        }

        public void Add(IMyComparable comparable) { }//doesnt do anything, just to fulfill the interface requiremen 

        public bool Contains(IMyComparable comparable)
        {
            return this._stacked.Contains(comparable)||this._queued.Contains(comparable);
            // "||" is the logical OR operator, true if one or both are true, false if both are false

        }

        //(Week 2) Exercise 6: I implement the createIterator function because the collectionable interface implements it
        public IIterator CreateIterator()
        {
            return null;
        }
    }
}
