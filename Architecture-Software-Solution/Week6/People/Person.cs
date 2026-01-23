using System;

namespace Week6
{
    public abstract class Person : IMyComparable
    {
        protected string _name;
        protected int _id;

        public Person(string name, int id)
        {
            this._name=name;
            this._id=id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetId()
        {
            return _id;
        }

        //Interface methods implementation
        public virtual bool IsEqual(IMyComparable comparable)
        {
            return (_id==((Person)comparable)._id);
        }

        public virtual bool IsLessThan(IMyComparable comparable)
        {
            return (_id<((Person)comparable)._id);
        }

        public virtual bool IsGreaterThan(IMyComparable comparable)
        {
            return (_id>((Person)comparable)._id);
        }


        public override string ToString()
        {
            return ("Name: "+_name+"\nID: "+_id.ToString());

        }
    }
}
