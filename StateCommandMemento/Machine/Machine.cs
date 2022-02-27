using System;

namespace Assignment2.StateCommandMemento
{
    internal class Machine : IMachine
    {
        public IMachineState MachineState { get; set; }
        public string Text { get; set; }
        public MachineHandler MachineHandler{ get; set; }

        public Machine()
        {
            MachineState = new MachineStateOff();
            MachineHandler = new MachineHandler();
        }

        public void Execute()
        {
            Console.WriteLine("Enter text to print");
            var text = Console.ReadLine();
            MachineHandler.AddCommand(this, MachineState, text);
            MachineHandler.Execute(MachineState);
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
                MachineHandler.Execute(MachineState);
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }
    }
}