using System;
using System.Collections.Generic;

namespace Assignment2.Facade
{
    class WordFacade
    {
        public List<List<char>> Words { get; set; }
        public List<char> Characters { get; set; }
        public List<char> Word { get; set; }

        public WordFacade()
        {
            Words = new List<List<char>>();
            Word = new List<char>();
        }
        public void Save()
        {
            Console.WriteLine("Write a 5 character word:");
            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadLine();
            }
            for (int i = 0; i < input.Length; i++)
            {
                List<char> character = new List<char>();
                Words.Add(character);
                character.Add(input[i]);
            }
        }

        public void Load()
        {

            foreach (var word in Words)
            {
                Console.Write(word[0]);
            }

            Console.ReadLine();

        }
    }
}