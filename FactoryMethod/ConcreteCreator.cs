namespace FactoryMethod
{
    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod() => new ConcreteProduct();
    }
}