namespace Assignment2.StateCommandMemento
{
    class MachineCommand : ICommand
    {
        public IMachine Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public string Text { get; set; }


        public MachineCommand(IMachine machine, IMachineState machineState, string text)
        {
            Machine = machine;
            MachineState = machineState;
            Text = text;
        }

        public IMachineState GetMachineState()
        {
            return MachineState;
        }
    }
}