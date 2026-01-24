using System;


namespace Week7.ChainOfResponsability_Pattern
{
    //(Week 7) Implemment the chain of responsability pattern for creation
    public abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;
        public BaseHandler(BaseHandler handler)
        {
            _nextHandler = handler;
        }

        
        //Data Keyboard Reader
        public virtual int KeyboardNumber()
        {
            if (_nextHandler!=null)
            {
                return _nextHandler.KeyboardNumber();
            }
            return 0;
        }

        public virtual string KeyboardString()
        {
            if (_nextHandler!=null)
                return _nextHandler.KeyboardString();
            return "hello";
        }

        //Random Data Generator
        public virtual int RandomNumber(int max = 10)
        {
            if (_nextHandler!=null)
                return _nextHandler.RandomNumber(max);
            return 0;
        }

        public virtual string RandomString(int cant = 6)
        {
            if (_nextHandler!=null)
                return _nextHandler.RandomString(cant);
            return "hola";
        }

        //File Data Reader
        public virtual double NumberFromFile(double max = 10)
        {
            if (_nextHandler!=null)
                return _nextHandler.NumberFromFile(max);
            return 0;
        }

        public virtual string StringFromFile(int cant = 6)
        {
            if (_nextHandler!=null)
                return _nextHandler.StringFromFile(cant);
            return "hola";
        }
    }
}
