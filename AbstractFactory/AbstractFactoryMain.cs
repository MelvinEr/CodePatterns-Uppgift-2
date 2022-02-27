namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public void Run()
        {
            var factoryFactory = new FactoryFactory();

            var dogFactory = factoryFactory.GetType("dog");
            var catFactory = factoryFactory.GetType("cat");
            
            var dog = dogFactory.CreateAnimal("Nelson");   
            var cat = catFactory.CreateAnimal("Findus");
        }
    }
}
