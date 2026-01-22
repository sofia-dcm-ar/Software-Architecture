using System;
using Week4.Decorator_Pattern;

namespace Week4.FactoryMethod_Pattern
{
    public class AlumnoBaseDecoratorFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            return this.Decorate(MyComparableFactory.RandomCreate(2));
        }

        public override IMyComparable KeyboardCreate()
        {
            return this.Decorate(MyComparableFactory.KeyboardCreate(2));
        }

        private IMyComparable Decorate(IMyComparable comparable)
        {
            FileNumberDecorator decoration0 = new FileNumberDecorator((Alumno)comparable);
            var decoration1 = new LetterDecorator(decoration0);
            var decoration2 = new StatusDecorator(decoration1);
            var decoration3 = new ContainerDecorator(decoration2);
            return decoration3;
        }
    }
}
