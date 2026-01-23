using System;
using Week5.Decorator_Pattern;

namespace Week5.FactoryMethod_Pattern
{
    public class DiligentAlumnoBaseDecoratorFactory : MyComparableFactory
    {
        public override IMyComparable RandomCreate()
        {
            return this.Decorate(MyComparableFactory.RandomCreate(4));
        }

        public override IMyComparable KeyboardCreate()
        {
            return this.Decorate(MyComparableFactory.KeyboardCreate(4));
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
