using System;
using Week4.Observer_Pattern;
using Week4.Strategy_Pattern;

namespace Week4.People
{
    //(Week 4) Exercise 6: Implement the decorator pattern to show califications
    //This is the interface to use all the alumnos in a general way
    public interface IAlumno : IMyComparable, IObserver
    {
        string GetName();
        int GetId();
        int GetFileNumber();
        double GetAverage();
        void SetCalification(int calification);
        int GetCalification();
        void SetStrategy(IComparisonStrategy strategy);
        void PayAttention();
        void LoseFocus();
        int AnswerQuestion(int question);
        string ShowCalification();
    }
}
