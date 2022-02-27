using System;

namespace Assignment2.Adapter
{
    class Adapter
    {
        public int StringToInt(string input)
        {
            return(Convert.ToInt32(input));
        }
    }
}
