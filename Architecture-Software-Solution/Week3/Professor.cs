using System;
using Week3.Observer_Pattern;

namespace Week3
{
    //(Week 3) Exercise 8: Create the Professor class, subclass of Person
    public class Professor : Person , IObservable
    {
        private int _tenure;
        private List<IObserver> _alumnos;
        private bool _speaking; //The professor speaks or writes?

        public Professor(int tenure, string name, int id) : base(name, id)
        {
            this._tenure=tenure;
            this._alumnos = new List<IObserver>();
            this._speaking=false;
        }

        public int GetTenure()
        {
            return this._tenure;
        }

        public bool GetSpeaking()
        { 
            //Exercise 12: so that the student updates the professor's action
            return this._speaking;
        }

        public override string ToString()
        {
            return base.ToString()+string.Format("\nTenure : {0} year/s", _tenure);
        }

        //(Week 3) Exercise 9: implement the IMyComparable methods to compare by tenure
        public override bool IsEqual(IMyComparable other)
        {
            return (_tenure==((Professor)other)._tenure);
        }

        public override bool IsLessThan(IMyComparable other)
        {
            return (_tenure<((Professor)other)._tenure);
        }

        public override bool IsGreaterThan(IMyComparable other)
        {
            return (_tenure>((Professor)other)._tenure);
        }

        //Acciones del profesor
        public void SpeakToTheClass()
        {
            Console.WriteLine("\nTalking to the class\n");
            this._speaking=true;
            this.Notify();
        }

        public void WriteInTheBoard()
        {
            Console.WriteLine("\nWriting on the board\n");
            this._speaking=false;
            this.Notify();
        }


        //(Week 3) OBSERVER -> Exercise 12: implement the Observer pattern, the professor is an observed

        public void Attach(IObserver o)
        {
            this._alumnos.Add(o);
        }

        public void Detach(IObserver o)
        {
            this._alumnos.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in _alumnos)
                o.Update(this);
        }
    }
}
