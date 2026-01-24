using System;
using System.Collections.Generic;
using Week7.Strategy_Pattern;
using Week7.Observer_Pattern;

namespace Week7.People
{
    //(Clase 6)Ejercicio 1: Cree un alumno compuesto de IAlumnos
    // Las hojas son : Alumno ; Alumno muy estudioso ; Alumno Proxy ; Alumno Decorado

    public class CompositeAlumno : IAlumno
    {
        private List<IAlumno> _children;

        public CompositeAlumno()
        {
            _children = new List<IAlumno>();
        }

        //List methods
        public void Add(IAlumno child)
        {
            _children.Add(child);
        }

        public int Count(int cant = 1)
        {//start as 1 because is counting himself 
            int i = cant;
            foreach (IAlumno child in _children)
            {
                i++;
                if (child is CompositeAlumno)//Recursive Delegation
                    i=((CompositeAlumno)child).Count(i);
            }
            return i;
        }

        public bool Remove(IAlumno alumno, bool removed = false)
        {
            if (_children.Remove(alumno)) //remove directly if it's one direct children
                return true;
            foreach (IAlumno child in _children)
            {
                if (child is CompositeAlumno)
                { 
                    removed = ((CompositeAlumno)child).Remove(alumno, removed);
                    if (removed) 
                        return true;
                }
            }
            return false; 
        }

        //behavior defined by practice

        //Alumno:
        public string GetName()
        {
            string names = "";
            foreach (IAlumno child in _children)
            {
                names += (child.GetName()+" , ");
            }
            return names;
        }

        public int AnswerQuestion(int question)
        {
            int[] answers = { 0, 0, 0 };
            foreach (IAlumno child in _children)
                answers[child.AnswerQuestion(question) - 1] += 1;

            int actual = 1;
            if (answers[1] > answers[0])
            {
                actual = 2;
                if (answers[2] > answers[1])
                    actual= 3;
            }
            return actual;
        }

        public void SetCalification(int calification)
        {
            foreach (IAlumno child in _children)
            {
                child.SetCalification(calification);
            }
        }

        public string ShowCalification()
        {
            string califications = "";
            foreach (IAlumno child in _children)
            {
                califications += (child.ShowCalification()+"\n");
            }
            return califications;
        }
        //IMyComparable
        public bool IsEqual(IMyComparable c)
        {
            if (this == c) 
                return true;
            foreach (IAlumno child in _children)
            {
                if (child.IsEqual(c))
                    return true;
            }
            return false;
        }

        public bool IsLessThan(IMyComparable c)
        {
            foreach (IAlumno child in _children)
            {
                if (!child.IsLessThan(c))
                    return false;
            }
            return true;
        }
        public bool IsGreaterThan(IMyComparable c)
        {
            foreach (IAlumno child in _children)
            {
                if (!child.IsGreaterThan(c))
                    return false;
            }
            return true;
        }

        //Alumno

        public int GetId()
        {
            return 0;
        }

        public int GetFileNumber()
        {
            return 0;
        }

        public double GetAverage()
        {
            double average = 0;
            foreach (IAlumno child in _children)
            {
                average+= child.GetAverage();
            }
            return average/_children.Count;
        }

        public int GetCalification()
        {
            return 0;
        }
        public void SetStrategy(IComparisonStrategy strategy)
        {
            foreach (IAlumno child in _children)
                child.SetStrategy(strategy);

        }
        public void PayAttention()
        {
            foreach (IAlumno child in _children)
                child.PayAttention();

        }
        public void LoseFocus()
        {
            foreach (IAlumno child in _children)
                child.LoseFocus();
        }

        public void SetName(string nombre)
        { 
            foreach (IAlumno child in _children)
                child.SetName(nombre);
        }

        //Observer
        public void Update(IObservable observable)
        {
            foreach (IAlumno child in _children)
                child.Update(observable);
        }
    }
}
