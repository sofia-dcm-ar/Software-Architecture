using System;
using System.Collections.Generic;
using Week2.Iterator_Pattern;

namespace Week2.MyCollections
{
    //(Week 1) Exercise 4.B: Implement Queue class and with IMyCollection interface
    public class MyQueue : IMyCollection
    {
        private readonly List<IMyComparable> _queued;

        public MyQueue()
        {
            _queued= new List<IMyComparable>();
        }

        public void Enqueue(IMyComparable comparable)
        {
            _queued.Add(comparable);
        }

        public IMyComparable Dequeue()
        {
            IMyComparable element = _queued[0];
            _queued.RemoveAt(0);
            return element;
        }

        //Interface methods implementation
        public int Count()
        {
            return _queued.Count;
        }

        public IMyComparable Minimum()
        {
            IMyComparable smaller = _queued[0];
            for (int i = 1; i<_queued.Count; i++)
            {
                if (_queued[i].IsLessThan(smaller))
                    smaller=_queued[i];
            }
            return smaller;
        }

        public IMyComparable Maximum()
        {
            IMyComparable larger = _queued[0];
            for (int i = 1; i<_queued.Count; i++)
            {
                if (_queued[i].IsGreaterThan(larger))
                    larger=_queued[i];
            }
            return larger;
        }

        public void Add(IMyComparable comparable)
        {
            Enqueue(comparable);
        }

        public bool Contains(IMyComparable comparable)
        {
            foreach (IMyComparable actual in _queued)
            {
                if (actual.IsEqual(comparable)) 
                    return true;
            }
            return false;
        }


        //(Week 2) ITERATOR -> Exercise 5: Make the Stack, Queue, Set classes implement the iterable interface

        public IIterator CreateIterator()
        {
            return new MyQueueIterator (this); //returns the concrete iterator 
        }

        public IMyComparable GetElement(int i)
        { //create this method to allow the iterator to access the specific elements
            return _queued[i];
        }
    }
}
