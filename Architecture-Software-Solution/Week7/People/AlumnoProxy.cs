using System;
using Week7.FactoryMethod_Pattern;
using Week7.Strategy_Pattern;
using Week7.Observer_Pattern;

namespace Week7.People
{
    public class AlumnoProxy : IAlumno
    {
        private IAlumno _realAlumno; //In some moment a proxy should create the real object
        private string _name;
        private int _option; //for create the IAlumno selected ( 2 Alumno )( 4 DiligentAlumno )( 5 AlumnoBaseDecorator )( 6 DiligentAlumnoBaseDecorator )

        public AlumnoProxy(string name, int option)
        {
            this._name=name;
            this._option=option;
        }

        //IAlumno methods , immplemented as an Adapter Pattern
        public string GetName()
        {
            return this._name;
        }
        public void SetName(string name)
        {
            if (this._realAlumno!=null)
            {
                this._realAlumno.SetName(name); 
            }
            this._name=name; 
        }

        public int AnswerQuestion(int question)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.AnswerQuestion(question);
        }

        //Create method, private because is only used internally
        private void CreateProxy()
        {
            this._realAlumno=(IAlumno)MyComparableFactory.RandomCreate(this._option);
            this._realAlumno.SetName(this._name);
            Console.WriteLine("<< Real IAlumno created >>");
        }

        public int GetId()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.GetId();
        }

        public int GetFileNumber()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.GetFileNumber();
        }

        public double GetAverage()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.GetAverage();
        }

        public void SetCalification(int calification)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            this._realAlumno.SetCalification(calification);
        }

        public int GetCalification()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.GetCalification();
        }

        public void SetStrategy(IComparisonStrategy strategy)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            this._realAlumno.SetStrategy(strategy);
        }

        public void PayAttention()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            this._realAlumno.PayAttention();
        }

        public void LoseFocus()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            this._realAlumno.LoseFocus();
        }

        public string ShowCalification()
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.ShowCalification();
        }

        public bool IsEqual(IMyComparable comparable)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.IsEqual(comparable);
        }
        public bool IsLessThan(IMyComparable comparable)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.IsLessThan(comparable);
        }
        public bool IsGreaterThan(IMyComparable comparable)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            return this._realAlumno.IsGreaterThan(comparable);
        }

        public void Update(IObservable observable)
        {
            if (this._realAlumno==null)
                this.CreateProxy();
            this._realAlumno.Update(observable);
        }
    }
}
