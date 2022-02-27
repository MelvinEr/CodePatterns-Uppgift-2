namespace Assignment2.StateCommandMemento
{
    public interface IMachineState
    {
        public void Print(IMachineState machineState, string text);
        public void PowerSwitch();     
    }
}