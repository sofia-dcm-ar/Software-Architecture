using System;
using Week7.People;

namespace Week7.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Implement the concrete factories
    //(Week 6) create a new factory for Composite Alumno
    //(Week 7) Add the Chain of handlers
    public class CompositeAlumnoFactory : MyComparableFactory
    {
        public CompositeAlumnoFactory()
        {
            this.CreateChainOfHandlers();
        }

        public override IMyComparable RandomCreate()
        {
            CompositeAlumno composite = new CompositeAlumno();
            for (int i = 0; i<5; i++)
            {
                AlumnoProxy proxy = new AlumnoProxy(_chainOfHandlers.RandomString(), 5);//Decorated Alumno
                composite.Add(proxy);
            }
            return composite;
        }

        public override IMyComparable KeyboardCreate()
        {
            CompositeAlumno composite = new CompositeAlumno();
            for (int i = 0; i<5; i++)
            {
                AlumnoProxy proxy = new AlumnoProxy(_chainOfHandlers.KeyboardString(), 5);
                composite.Add(proxy);
            }
            return composite;
        }

        public override IMyComparable FileCreate()
        {
            CompositeAlumno composite = new CompositeAlumno();
            for (int i = 0; i<5; i++)
            {
                AlumnoProxy proxy = new AlumnoProxy(_chainOfHandlers.StringFromFile(), 5);
                composite.Add(proxy);
            }
            return composite;
        }
    }
}
