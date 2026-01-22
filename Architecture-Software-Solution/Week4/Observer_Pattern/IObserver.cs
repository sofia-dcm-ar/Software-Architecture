using System;

namespace Week4.Observer_Pattern
{
    //(Week 3) Exercise 12: Implement Observer pattern
    public interface IObserver
    {
        void Update(IObservable observable); //Receive update from observable
    }
}
