namespace Assignment2.StateCommandMemento
{
    public interface ICommand
    {
        IMachine Machine { get; set; }
        IMachineState MachineState { get; set; }
        IMachineState GetMachineState();
        string Text { get; set; }
    }
}