using System;
using Week6.MyCollections;

namespace Week6.Iterator_Pattern
{
    //(Week 2) Exercise 5: Make Stack, Queue and Set classes implement the iterable interface
    public class MyStackIterator : IIterator
    {
        private readonly MyStack _stacked;
        private int _index;

        public MyStackIterator(MyStack stacked)
        {
            _stacked=stacked;
            this.First();
        }

        public void First()
        {
            _index=_stacked.Count()-1;
        }

        public void Next()
        {
            _index--;
        }

        public bool IsDone()
        {
            return (_index<0);
        }

        public IMyComparable CurrentItem()
        {
            return (_stacked.GetElement(_index));
        }

    }
}
