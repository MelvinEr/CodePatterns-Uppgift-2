using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    class Dog : IAnimal, IDog
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
