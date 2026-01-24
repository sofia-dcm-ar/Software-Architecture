using System;

namespace Week7.Observer_Pattern
{
    //(Week 3) Exercise 12: Implement Observer pattern
    public interface IObserver
    {
        void Update(IObservable observable); //Receive update from observable
    }
}
