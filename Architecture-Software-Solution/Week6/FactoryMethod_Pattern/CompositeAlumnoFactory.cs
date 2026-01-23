using System;
using Week6.People;

namespace Week6.FactoryMethod_Pattern
{
    //(Week 6) Exercise 2: create a new factory for Composite Alumno
    public class CompositeAlumnoFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            CompositeAlumno composite = new CompositeAlumno();
            for (int i = 0; i<5; i++)
            {
                AlumnoProxy proxy = new AlumnoProxy(_create.RandomString(), 5);//Decorated Alumno
                composite.Add(proxy);
            }
            return composite;
        }

        public override IMyComparable KeyboardCreate()
        {
            CompositeAlumno composite = new CompositeAlumno();
            for (int i = 0; i<5; i++)
            {
                AlumnoProxy proxy = new AlumnoProxy(_read.KeyboardString(), 5);
                composite.Add(proxy);
            }
            return composite;
        }
    }
}
