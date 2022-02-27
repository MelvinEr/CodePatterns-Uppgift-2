namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           

            // ReturningStrings
            // PrintingInts

            Adapter adapter = new Adapter();
            ReturningStrings returningStrings = new();
            PrintingInts printingInts = new();
            printingInts.Print(adapter.StringToInt(returningStrings.ReturnString()));            
        }
    }
}
