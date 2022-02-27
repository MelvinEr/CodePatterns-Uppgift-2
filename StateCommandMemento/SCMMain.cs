using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        public void Run()
        {
            Machine machine = new Machine();
            machine.MachineHandler.CreateMemento();
            bool isRunning = true;

            Console.WriteLine("1. Toggle machine ON/OFF");
            Console.WriteLine("2. Print text");
            Console.WriteLine("3. Remove all commands");
            Console.WriteLine("4. Exit program");

            while (isRunning)
            {
                var action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        machine.PowerSwitch();
                        break;
                    case ConsoleKey.D2:                 
                        machine.Execute();
                        break;
                    case ConsoleKey.D3:
                        machine.MachineHandler.Reset();
                        break;
                    case ConsoleKey.D4:
                        return;
                    default:
                        Console.WriteLine("Invald action");
                        break;
                }
            }
        }
    }
}