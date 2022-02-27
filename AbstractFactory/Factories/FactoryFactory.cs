using Assignment2.AbstractFactory.Factories;
using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    class FactoryFactory
    {
        internal IFactory GetType(string factoryType)
        {
            if(factoryType == "dog")
            {
                return new DogFactory();
            }
            else if(factoryType == "cat")
            {
                return new CatFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
