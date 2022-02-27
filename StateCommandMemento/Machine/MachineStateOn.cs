using System;

namespace Assignment2.StateCommandMemento
{
    class MachineStateOn : IMachineState
    {
        public void Print(IMachineState machineState, string text)
        {
            Console.WriteLine(text);
        }

        public void PowerSwitch()
        {
            Console.WriteLine("Machine is now turned OFF");
        }
    }
}