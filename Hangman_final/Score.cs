using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Score: Basic
    {
        private int guessLeft(string given, int counter)
        {
            int i = getChances(given);
            int j = counter;
            return i - j;
        }
        private int charLeft(string given, string rev)
        {
            int letter = given.Length - compare(given, rev);
            return letter;
        }
        public Score(string given)
        {
            int guesses = getChances(given);
            Console.WriteLine("Total guesses: " + guesses);
        }
        public void dispTable(string given, string rev, int counter)
        {
            
            int tries = guessLeft(given, counter);
            int letters = charLeft(given, rev);
            Console.WriteLine($"Tries Left: {tries}  Letters Left: {letters}");
        }
    }
}