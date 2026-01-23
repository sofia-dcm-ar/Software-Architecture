using System;
using System.Collections.Generic;
using Week6.Iterator_Pattern;
using Week6.Command_Pattern;

namespace Week6.MyCollections
{
    public class MyQueue : IMyCollection, IOrderable
    {
        private readonly List<IMyComparable> _queued;

        //(Week 5) COMMAND -> Exercise 9.B: Implement the necessary attributes for the Orderable interface
        //The queue can be just a queue or have orders associated with it 
        IClassroomCommand1 _startCommand;
        IClassroomCommand1 _fullClassroomCommand;
        IClassroomCommand2 _alumnoArrivalCommand;

        public MyQueue()
        {
            _queued= new List<IMyComparable>();
        }

        //(Week 5) COMMAND -> Necesary changes for immplement the commands
        public void Enqueue(IMyComparable comparable)
        {
            _queued.Add(comparable);

            //Only if commands are active
            if (this.Count()==1 && _startCommand!=null) 
                _startCommand.Execute();

            if (_alumnoArrivalCommand!=null) 
                _alumnoArrivalCommand.Execute(comparable);

            if (this.Count()==40 && _fullClassroomCommand!=null)  
                this._fullClassroomCommand.Execute();
        }

        public IMyComparable Dequeue()
        {
            IMyComparable element = _queued[0];
            _queued.RemoveAt(0);
            return element;
        }

        //Interface methods implementation
        public int Count()
        {
            return _queued.Count;
        }

        public IMyComparable Minimum()
        {
            IMyComparable smaller = _queued[0];
            for (int i = 1; i<_queued.Count; i++)
            {
                if (_queued[i].IsLessThan(smaller))
                    smaller=_queued[i];
            }
            return smaller;
        }

        public IMyComparable Maximum()
        {
            IMyComparable larger = _queued[0];
            for (int i = 1; i<_queued.Count; i++)
            {
                if (_queued[i].IsGreaterThan(larger))
                    larger=_queued[i];
            }
            return larger;
        }

        public void Add(IMyComparable comparable)
        {
            Enqueue(comparable);
        }

        public bool Contains(IMyComparable comparable)
        {
            foreach (IMyComparable actual in _queued)
            {
                if (actual.IsEqual(comparable)) 
                    return true;
            }
            return false;
        }


        //(Week 2) ITERATOR -> 

        public IIterator CreateIterator()
        {
            return new MyQueueIterator (this); 
        }

        public IMyComparable GetElement(int i)
        { 
            return _queued[i];
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
