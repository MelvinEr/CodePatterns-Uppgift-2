using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory.Factories
{
    internal class CatFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Cat(name);
        }
    }
}