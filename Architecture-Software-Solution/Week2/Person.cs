using System;

namespace Week2
{
    //Exercise 11: Implement abstract class Person, implement the IMyComparable interface
    public abstract class Person : IMyComparable
    {
        protected string _name;
        protected int _id;

        public Person(string name, int id)
        {
            _name=name;
            _id=id;
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
            return _id==((Person)comparable)._id;
        }

        public virtual bool IsLessThan(IMyComparable comparable)
        {
            return _id<((Person)comparable)._id;
        }

        public virtual bool IsGreaterThan(IMyComparable comparable)
        {
            return _id>((Person)comparable)._id;
        }


        public override string ToString()
        {
            return "Name: "+_name+"\nID: "+_id.ToString();

        }
    }
}
