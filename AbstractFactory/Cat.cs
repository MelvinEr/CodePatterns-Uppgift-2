using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    class Cat : IAnimal, ICat
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
