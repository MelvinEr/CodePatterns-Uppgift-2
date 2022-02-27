using System;

namespace Assignment2.StateCommandMemento
{
    class MachineStateOff : IMachineState
    {
        public void Print(IMachineState machineState, string text)
        {
            if (machineState.Equals(this))
            {
                Console.WriteLine("Machine is turned off, unable to print");
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        public void PowerSwitch()
        {
            Console.WriteLine("Machine is now turned ON");
        }
    }
}