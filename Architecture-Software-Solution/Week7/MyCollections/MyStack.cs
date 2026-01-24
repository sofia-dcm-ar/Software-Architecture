using System;
using System.Collections.Generic;
using Week7.Command_Pattern;
using Week7.Iterator_Pattern;

namespace Week7.MyCollections
{
    public class MyStack : IMyCollection
    {
        private readonly List<IMyComparable> _stacked;
        //(Week 5) COMMAND -> Exercise 9.B: Implement the necessary attributes for the Orderable interface
        //The queue can be just a queue or have orders associated with it 
        IClassroomCommand1 _startCommand;
        IClassroomCommand1 _fullClassroomCommand;
        IClassroomCommand2 _alumnoArrivalCommand;

        public MyStack()
        {
            _stacked = new List<IMyComparable>();
        }

        //(Week 5) COMMAND -> Necesary changes for immplement the commands
        public void Push(IMyComparable comparable)
        {
            _stacked.Add(comparable);

            //Only if commands are active
            if (this.Count()==1 && _startCommand!=null)
                _startCommand.Execute();

            if (_alumnoArrivalCommand!=null)
                _alumnoArrivalCommand.Execute(comparable);

            if (this.Count()==40 && _fullClassroomCommand!=null)
                this._fullClassroomCommand.Execute();
        }

        public IMyComparable Pop()
        {
            IMyComparable stack = _stacked[_stacked.Count -1];
            _stacked.RemoveAt(_stacked.Count -1);
            return stack;
        }

        //Interface methods implementation
        public int Count()
        {
            return _stacked.Count;
        }

        public IMyComparable Minimum()
        {
            IMyComparable smaller = _stacked[0];
            for (int i = 1; i<_stacked.Count; i++)
            {
                if (_stacked[i].IsLessThan(smaller))
                    smaller=_stacked[i];
            }
            return smaller;
        }

        public IMyComparable Maximum()
        {
            IMyComparable larger = _stacked[0];
            for (int i = 1; i<_stacked.Count; i++)
            {
                if (_stacked[i].IsGreaterThan(larger))
                    larger=_stacked[i];
            }
            return larger;
        }

        public void Add(IMyComparable c)
        {
            Push(c);
        }

        public bool Contains(IMyComparable c)
        {
            foreach (IMyComparable actual in _stacked)
            {
                if (actual.IsEqual(c))
                    return true;
            }
            return false;
        }

        //(Week 2) ITERATOR ->
        public IIterator CreateIterator()
        {
            return new MyStackIterator(this); 
        }

        public IMyComparable GetElement(int i)
        { 
            return _stacked[i];
        }

        //(Week 5) COMMAND -> Exercise 9.B: Implement the necessary methods for the Orderable interface
        public void SetStartCommand(IClassroomCommand1 command)
        {
            _startCommand=command;
        }
        public void SetAlumnoArrivalCommand(IClassroomCommand2 command)
        {
            _alumnoArrivalCommand=command;
        }
        public void SetFullClassroomCommand(IClassroomCommand1 command)
        {
            _fullClassroomCommand=command;
        }
    }
}
