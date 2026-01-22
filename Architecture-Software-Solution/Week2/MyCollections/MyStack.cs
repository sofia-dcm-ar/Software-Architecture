using System;
using System.Collections.Generic;
using Week2.Iterator_Pattern;

namespace Week2.MyCollections
{
    //(Week 1) Exercise 4.A: Implement Stack class and implement IMyCollection interface
    public class MyStack : IMyCollection
    {
        private readonly List<IMyComparable> _stacked;

        public MyStack()
        {
            _stacked = new List<IMyComparable>();
        }

        public void Push(IMyComparable comparable)
        {
            _stacked.Add(comparable);
        }

        public IMyComparable Pop()
        {
            IMyComparable stack = _stacked[_stacked.Count -1];
            _stacked.RemoveAt(_stacked.Count -1);
            return stack;
        }

        //Interface methods implementation
        public int Count()
        {
            return _stacked.Count;
        }

        public IMyComparable Minimum()
        {
            IMyComparable smaller = _stacked[0];
            for (int i = 1; i<_stacked.Count; i++)
            {
                if (_stacked[i].IsLessThan(smaller))
                    smaller=_stacked[i];
            }
            return smaller;
        }

        public IMyComparable Maximum()
        {
            IMyComparable larger = _stacked[0];
            for (int i = 1; i<_stacked.Count; i++)
            {
                if (_stacked[i].IsGreaterThan(larger))
                    larger=_stacked[i];
            }
            return larger;
        }

        public void Add(IMyComparable c)
        {
            Push(c);
        }

        public bool Contains(IMyComparable c)
        {
            foreach (IMyComparable actual in _stacked)
            {
                if (actual.IsEqual(c))
                    return true;
            }
            return false;
        }

        //(Week 2) ITERATOR -> Exercise 5: Make the Stack, Queue, Set classes implement the iterable interface
        public IIterator CreateIterator()
        {
            return new MyStackIterator(this); //returns the concrete iterator 
        }

        public IMyComparable GetElement(int i)
        { //create this method to allow the iterator to access the specific elements
            return _stacked[i];
        }
    }
}
