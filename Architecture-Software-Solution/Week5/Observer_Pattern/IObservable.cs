using System;


namespace Week5.Observer_Pattern
{
    //(Week 3) Exercise 12: Implement Observer pattern
    public interface IObservable
    {
        void Attach(IObserver observer); //Add observer
        void Detach(IObserver observer); //Remove observer
        void Notify(); //Notify all observers of a change
    }
}
