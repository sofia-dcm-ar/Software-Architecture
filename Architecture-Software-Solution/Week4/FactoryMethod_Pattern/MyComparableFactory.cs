using System;

namespace Week4.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Exercise 4: Implement the abstract class Factory
    public abstract class MyComparableFactory
    {
        protected RandomDataGenerator _create = new RandomDataGenerator();
        protected DataKeyboardReader _read = new DataKeyboardReader();

        //static methods to create the factories and use them
        public static IMyComparable RandomCreate(int option)
        {
            return CreateFactory(option).RandomCreate();
        }

        public static IMyComparable KeyboardCreate(int option)
        {
            return CreateFactory(option).KeyboardCreate();
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
            }
            return factory;
        }

        //Metodos de las factorys que heredan
        public abstract IMyComparable RandomCreate();

        public abstract IMyComparable KeyboardCreate();
    }
}
