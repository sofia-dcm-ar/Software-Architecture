using System;
using Week7.Decorator_Pattern;

namespace Week7.FactoryMethod_Pattern
{
    //(Week 3) FACTORY METHOD -> Implement the concrete factories
    //(Week 7) Add the Chain of handlers
    public class DiligentAlumnoBaseDecoratorFactory : MyComparableFactory
    {
        public DiligentAlumnoBaseDecoratorFactory()
        {
            this.CreateChainOfHandlers();
        }

        public override IMyComparable RandomCreate()
        {
            return this.Decorate(MyComparableFactory.RandomCreate(4));
        }

        public override IMyComparable KeyboardCreate()
        {
            return this.Decorate(MyComparableFactory.KeyboardCreate(4));
        }
        public override IMyComparable FileCreate()
        {
            return this.Decorate(MyComparableFactory.FileCreate(4));
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
