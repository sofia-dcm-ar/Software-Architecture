using System;
using Week3.MyCollections;

namespace Week3.Iterator_Pattern
{
    //(Week 2) Exercise 5: Make Stack, Queue and Set classes implement the iterable interface
    public class MyQueueIterator : IIterator
    {
        private MyQueue _queued;
        private int _index;
        public MyQueueIterator(MyQueue queued)
        {
            _queued=queued;
            this.First();
        }

        public void First()
        {
            _index=0;
        }

        public void Next()
        {
            _index++;
        }

        public bool IsDone()
        {
            return (_index>=_queued.Count());
        }

        public IMyComparable CurrentItem()
        {
            return (_queued.GetElement(_index));
        }
    }
}
