using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.SqlServer.Server;

namespace Hangman
{
    interface IRandomizer
    {
        string getWord(int difficulty_level);
        string reveal(bool change, string word);
        string update(string word, string revealed_part, char guessed_char);
    }
    abstract class Rand: Basic
    {
        protected Dictionary<int, string> words = new Dictionary<int, string> { };
        Words from_dict = new Words();
        public Rand()
        {
            words = from_dict.words_dict;
        }
        public string reveal(bool change, string given)
        {
            int s = given.Length;
            string rev = null;
            int place1;
            int place2;
            Random random = new Random();
            place1 = random.Next(1, s);
            place2 = random.Next(1, s);
            if (place1 == place2)
            {
                place1 = 0;
            }
            int place3 = -1;
            if (change)
            {
                do
                {
                    place3 = random.Next(1, s);
                } while (place3 == place1 || place3 == place2);
            }
            for (int i = 0; i < s; i++)
            {
                if (i == place1 || i == place2 || i == place3)
                {
                    rev += given[i];
                }
                else
                {
                    rev += '_';
                }
            }
            return rev;
        }
        public string update(string given, string rev, char guess)
        {
            string newrev = null;
            if (checkIt(given, guess))
            {
                Console.WriteLine("Right!");
                int i = given.IndexOf(guess);
                int s = rev.Length;
                for (int j = 0; j < s; j++)
                {
                    if (given[j] == guess || rev[j] != '_')
                    {
                        newrev += given[j];
                    }
                    else
                    {
                        newrev += '_';
                    }
                }
                return newrev;
            }
            Console.WriteLine ("Wrong guess");
            return rev;
        }
    }
    class RandAll: Rand, IRandomizer
    {
        public string getWord(int Idiff)
        {
            int getIndex;
            Random random = new Random();
            getIndex = random.Next(1, 61);
            return words[getIndex];
        }
    }
    class RandDiff : Rand, IRandomizer
    {
        public string getWord(int Idiff)
        {
            int getIndex;
            Random random = new Random();
            int[] index = new int[2];
            int period = 30;
            if (Idiff == 3)
            {
                int easyMin = 1;
                int easyMax = 10;
                index[0] = random.Next(easyMin, easyMax + 1);
                easyMin += period;
                easyMax += period;
                index[1] = random.Next(easyMin, easyMax + 1);
            }
            else if (Idiff == 2)
            {
                int mediumMin = 11;
                int mediumMax = 20;
                index[0] = random.Next(mediumMin, mediumMax + 1);
                mediumMin += period;
                mediumMax += period;
                index[1] = random.Next(mediumMin, mediumMax + 1);
            }
            else if (Idiff == 1)
            {
                int hardMin = 21;
                int hardMax = 30;
                index[0] = random.Next(hardMin, hardMax);
                hardMin += period;
                hardMax += period;
                index[1] = random.Next(hardMin, hardMax);
            }
            getIndex = index[random.Next(0, 2)];
            return words[getIndex];
        }

    }
};
