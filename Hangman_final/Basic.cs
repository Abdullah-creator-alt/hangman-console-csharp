using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Basic
    {
        public int difficultyLevel(string diff)
        {
            diff = diff.ToLower();
            do
            {
                switch (diff[0])
                {
                    case 'e':
                        return 3;           //3 if easy
                    case 'm':
                        return 2;           //2 if medium
                    case 'h':
                        return 1;           //1 if hard
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            } while (true);
        }
        public bool checkIt(string given, char guess)
        {
            if (given.Contains(guess))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected int compare(string given, string rev)
        {
            int count = 0;
            int i = 0;
            foreach (char c in given)
            {
                if (c == rev[i])
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        public bool done(string given, string rev)
        {
            int getCount = compare(given, rev);
            bool got = false;
            if (getCount == given.Length)
            {
                got = true;
            }
            return got;
        }
        public int getChances(string given)
        {
            int length = given.Length;
            return length;
        }
    }
}