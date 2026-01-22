using System;
using System.Collections.Generic;
using Week3.Iterator_Pattern;

namespace Week3.MyCollections
{
    //(Week 2) Exercise 3: Implement Set class. It is a collection that stores elements without repetition
    public class MySet : IMyCollection
    {
        private readonly List<IMyComparable> _set;

        public MySet()
        {
            _set = new List<IMyComparable>();
        }

        public void Add(IMyComparable c)
        {
            if (!Contains(c))
                _set.Add(c);
        }


        //Interface methods implementation
        public int Count()
        {
            return _set.Count;
        }

        public IMyComparable Minimum()
        {
            IMyComparable smaller = _set[0];
            for (int i = 1; i<_set.Count; i++)
            {
                if (_set[i].IsLessThan(smaller))
                    smaller=_set[i];
            }
            return smaller;
        }

        public IMyComparable Maximum()
        {
            IMyComparable larger = _set[0];
            for (int i = 1; i<_set.Count; i++)
            {
                if (_set[i].IsGreaterThan(larger))
                    larger=_set[i];
            }
            return larger;
        }

        public bool Contains(IMyComparable comparable)
        {
            foreach (IMyComparable actual in _set)
            {
                if (actual.IsEqual(comparable))
                    return true;
            }
            return false;
        }

        //(Week 2) ITERATOR -> Exercise 5: Make the Stack, Queue, Set classes implement the iterable interface
        public IIterator CreateIterator()
        {
            return new MySetIterator(this); //returns the concrete iterator 
        }

        public IMyComparable GetElement(int i)
        { //create this method to allow the iterator to access the specific elements
            return _set[i];
        }
    }
}
