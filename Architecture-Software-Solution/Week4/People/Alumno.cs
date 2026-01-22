using System;
using Week4.Observer_Pattern;
using Week4.People;
using Week4.Strategy_Pattern;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week4
{
    //NOTE: "Alumno" stays in spanish for future Adapter pattern exercise
    public class Alumno : Person, IAlumno
    {
        private int _fileNumber;
        private double _average;
        private IComparisonStrategy _strategy; 
        private int _calification; //(Week 4) Exercise 1: add calification

        public Alumno(string name, int id, int fileNumber, double average) : base(name, id)
        {
            _fileNumber=fileNumber;
            _average=average;
            _strategy= new IDComparison();
            _calification=0;

        }

        // -------------- GETTERS AND SETTERS --------------
        public void SetStrategy (IComparisonStrategy newOne)
        {
            _strategy=newOne;
        }

        public int GetFileNumber()
        {
            return _fileNumber;
        }

        public double GetAverage()
        {
            return _average;
        }

        //(Week 4) Exercise 1: setter and getter for calification
        public void SetCalification(int calification)
        {
            _calification = calification;
        }

        public int GetCalification()
        {
            return _calification;
        }

        public override string ToString()
        {
            return base.ToString()+"\nFile Number: "+_fileNumber.ToString()+"\nAverage: "+((float)_average).ToString("F2");
            //the F2 indicates that I only want two decimals
        }

        //-------------- INTERFACE METHODS IMPLEMENTATION ---------------
        public override bool IsEqual(IMyComparable other)
        {
            return _strategy.IsEqual(this, (IAlumno)other);
        }

        public override bool IsLessThan(IMyComparable other)
        {
            return _strategy.IsLessThan(this, (IAlumno)other);
        }

        public override bool IsGreaterThan(IMyComparable other)
        {
            return _strategy.IsGreaterThan(this, (IAlumno)other);
        }

        // <--- Observer Pattern Methods --->
        public void PayAttention()
        {
            Console.WriteLine("Paying Attention");
        }

        public void LoseFocus()
        {
            Random r = new Random();
            string[] actions = { "Looking out the window", "Checking the phone", "Drawing in the margin of the folder", "Throwing paper airplanes" };
            Console.WriteLine(actions[r.Next(2)]);
        }

        public void Update(IObservable observable)
        {
            if (((Professor)observable).GetSpeaking())
                this.PayAttention();
            else
                this.LoseFocus();
        }

        // (Week 4) new methods
        public virtual int AnswerQuestion(int question)
        {
            Random r = new Random();
            return r.Next(1, 3);
        }

        public string ShowCalification()
        {
            return string.Format("{0}     {1}", _name, _calification);
        }
    }
}
