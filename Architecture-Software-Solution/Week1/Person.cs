using System;

namespace Week1
{
    //Exercise 11: Implement abstract class Person, implement the IMyComparable interface
    public abstract class Person : IMyComparable
    {
        protected string _name;
        protected int _dni;

        public Person(string name, int dni)
        {
            this._name=name;
            this._dni=dni;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetDni()
        {
            return _dni;
        }

        //Interface methods implementation
        public virtual bool IsEqual(IMyComparable comparable)
        {
            return (_dni==((Person)comparable)._dni);
        }

        public virtual bool IsLessThan(IMyComparable comparable)
        {
            return (_dni<((Person)comparable)._dni);
        }

        public virtual bool IsGreaterThan(IMyComparable comparable)
        {
            return (_dni>((Person)comparable)._dni);
        }


        public override string ToString()
        {
            return ("Name: "+_name+"\nDNI: "+_dni.ToString());

        }
    }
}
