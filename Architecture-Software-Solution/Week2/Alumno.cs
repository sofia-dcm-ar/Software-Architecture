using System;
using Week2.Strategy_Pattern;

namespace Week2
{
    //(Week 1)Exercise 12: Implement the Alumno class, subclass of Person
    //NOTE: "Alumno" stays in spanish for future Adapter pattern exercise
    public class Alumno : Person, IMyComparable
    {
        private int _fileNumber;
        private double _average;
        private IComparisonStrategy _strategy; //create a strategy attribute

        public Alumno(string name, int id, int fileNumber, double average) : base(name, id)
        {
            this._fileNumber=fileNumber;
            this._average=average;
            this._strategy= new IDComparison();//initialize with a default strategy
        }

        //(Week 2) Exercise 1: STRATEGY -> set the strategy
        public void SetStrategy (IComparisonStrategy newOne)
        {
            this._strategy=newOne;
        }

        public int GetFileNumber()
        {
            return _fileNumber;
        }

        public double GetAverage()
        {
            return _average;
        }

        //I teach it to print itself (thanks to problems when using the Report function in main, exercise 14)
        //But first I teach Person since it's also an IMyComparable and after exercise 6
        //I had already decided that each IMyComparable teaches itself to print itself, since in Report() I use the generalized ToString() for IMyComparables
        public override string ToString()
        {
            return base.ToString()+"\nI: "+_fileNumber.ToString()+"\nAverage: "+((float)_average).ToString("F2");
            //the F2 indicates that I only want two decimals
        }

        //(Week 1) Exercise 15: reimplement the comparable methods used in person to compare by _fileNumber or _average
        //(Week 2) Exercise 1: STRATEGY ->  now I delegate to the _strategy to do it
        public override bool IsEqual(IMyComparable other)
        {
            return _strategy.IsEqual(this, (Alumno)other);
        }

        public override bool IsLessThan(IMyComparable other)
        {
            return _strategy.IsLessThan(this, (Alumno)other);
        }

        public override bool IsGreaterThan(IMyComparable other)
        {
            return _strategy.IsGreaterThan(this, (Alumno)other);
        }
    }
}
