using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    public class MachineHandler
    {
        public IMachineState MachineState { get; set; }
        private List<ICommand> Commands { get; set; }
        
        public MachineHandler()
        {
            Commands = new();
        }

        public void AddCommand(IMachine machine, IMachineState machineState, string text)
        {
            ICommand command = new MachineCommand(machine, machineState, text);
            Commands.Add(command);
            MachineState = machineState;
        }

        public void Execute(IMachineState machineState)
        {

            foreach (var command in Commands)
            {
                command.MachineState.Print(machineState, command.Text);
            }
        }

        public void Reset()
        {
            Commands.Clear();
            Console.WriteLine("Commands cleared");
        }

        public List<ICommand> CreateMemento()
        {
            List<ICommand> Mementos = new();
            foreach (var command in Commands)
            {
                Mementos.Add(command);
            }
            return Mementos;
        }
    }
}