using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory.Factories
{
    internal class DogFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Dog(name);
        }
    }
}