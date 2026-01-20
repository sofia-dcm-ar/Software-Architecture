using System;

namespace Week1
{
    //Exercise 12: Implement the Alumno class, subclass of Person
    public class Alumno : Person, IMyComparable
    {
        private int _studentRecord;
        private double _average;

        public Alumno(string name, int dni, int record, double average) : base(name, dni)
        {
            _studentRecord=record;
            _average=average;
        }

        public int GetStudentRecord()
        {
            return _studentRecord;
        }

        public double GetAverage()
        {
            return _average;
        }

        //Exercise 15: reimplement the IMyComparable methods used in Person so that they compare by _studentRecord or _average

        public override bool IsEqual(IMyComparable other)
        {
            return (_studentRecord==((Alumno)other)._studentRecord);
        }

        public override bool IsLessThan(IMyComparable other)
        {
            return (_studentRecord<((Alumno)other)._studentRecord);
        }

        public override bool IsGreaterThan(IMyComparable other)
        {
            return (_studentRecord>((Alumno)other)._studentRecord);
        }

        //I teach it to print itself (thanks to problems when using the Report function in main, exercise 14)
        //But first I teach Person since it's also an IMyComparable and after exercise 6
        //I had already decided that each IMyComparable teaches itself to print itself, since in Report() I use the generalized ToString() for IMyComparables

        public override string ToString()
        {
            return base.ToString()+"\nStudent Record: "+_studentRecord.ToString()+"\nAverage: "+((float)_average).ToString("F2");
            //the F2 indicates that I only want two decimals
        }
    }
}
