using System;
using Week6.People;
using Week6.Strategy_Pattern;
using Week6.Observer_Pattern;

namespace Week6.Decorator_Pattern
{
    //(Week 4) Exercise 6: Implement the decorator pattern to show califications
    //Base decorator class that implements IAlumno and contains a reference to an IAlumno object
    public abstract class AlumnoBaseDecorator : IAlumno
    {
        private IAlumno _wrappee;
        public AlumnoBaseDecorator(IAlumno alumno)
        {
            this._wrappee = alumno;
        }

        //Alumno methods, same implementation as Adapter pattern

        public virtual string ShowCalification()
        { //Decorator method to be overridden
            return this._wrappee.ShowCalification();
        }

        public string GetName()
        {
            return this._wrappee.GetName();
        }
        public int GetId()
        {
            return this._wrappee.GetId();
        }
        public int GetFileNumber()
        {
            return this._wrappee.GetFileNumber();
        }

        public double GetAverage()
        {
            return this._wrappee.GetAverage();
        }

        public void SetStrategy(IComparisonStrategy strategy)
        {
            this._wrappee.SetStrategy(strategy);
        }

        public void SetCalification(int calification)
        {
            this._wrappee.SetCalification(calification);
        }

        public int GetCalification()
        {
            return this._wrappee.GetCalification();
        }

        public void PayAttention()
        {
            this._wrappee.PayAttention();
        }

        public void LoseFocus()
        {
            this._wrappee.LoseFocus();
        }

        public int AnswerQuestion(int question)
        {
            return this._wrappee.AnswerQuestion(question);
        }

        public bool IsEqual(IMyComparable comparable)
        {
            return this._wrappee.IsEqual(comparable);
        }

        public bool IsLessThan(IMyComparable comparable)
        {
            return this._wrappee.IsLessThan(comparable);
        }

        public bool IsGreaterThan(IMyComparable comparable)
        {
            return this._wrappee.IsGreaterThan(comparable);
        }

        public void Update(IObservable observable)
        {
            this._wrappee.Update(observable);
        }

        //(Week 5) Exercise 1: new method for proxy
        public void SetName(string name)
        {
            this._wrappee.SetName(name);
        }
    }
}
