using System;
using Week7.ChainOfResponsability_Pattern;

namespace Week7.FactoryMethod_Pattern
{
    //FACTORY METHOD -> Exercise 4: Implement the abstract class Factory
    //(Week 7) CHAIN OF RESPONSABILITY -> modify the factories for it to use the chain of handlers
    public abstract class MyComparableFactory
    {
        protected BaseHandler _chainOfHandlers;

        //static methods to create the factories and use them
        public static IMyComparable RandomCreate(int option)
        {
            return CreateFactory(option).RandomCreate();
        }

        public static IMyComparable KeyboardCreate(int option)
        {
            return CreateFactory(option).KeyboardCreate();
        }

        public static IMyComparable FileCreate(int option)
        { //(Clase 7) ejercicio 3
            return CreateFactory(option).FileCreate();
        }

        //Private Method to create the factories
        private static MyComparableFactory CreateFactory(int option)
        {
            MyComparableFactory factory = null;
            switch (option)
            {
                case 1:
                    factory = new MyNumberFactory();
                    break;
                case 2:
                    factory = new AlumnoFactory();
                    break;
                case 3:
                    factory = new ProfesorFactory();
                    break;
                case 4:
                    factory = new DiligentAlumnoFactory();
                    break;
                case 5:
                    factory = new AlumnoBaseDecoratorFactory();
                    break;
                case 6:
                    factory = new DiligentAlumnoBaseDecoratorFactory();
                    break;
                case 7:
                    factory = new CompositeAlumnoFactory();
                    break;
            }
            return factory;
        }

        //subfactory methods
        public abstract IMyComparable RandomCreate();

        public abstract IMyComparable KeyboardCreate();

        public abstract IMyComparable FileCreate();//(Week 7)

        protected void CreateChainOfHandlers()
        { //(Week 7) Singletone Pattern
            BaseHandler handler = DataKeyboardReader.GetInstance(null);
            handler = new FileDataReader(handler);
            handler = RandomDataGenerator.GetInstance(handler);
            _chainOfHandlers=handler;
        }
    }
}
