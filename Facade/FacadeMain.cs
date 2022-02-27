namespace Assignment2.Facade
{
    class FacadeMain
    {
       public void Run()
        {
            // Write a facade to make it easier to save and load words
            WordFacade wf = new WordFacade();

            // Spara 5 karaktärer stort ord
            wf.Save();

            // Ladda ord från listan
            wf.Load();
        }
    }
}
