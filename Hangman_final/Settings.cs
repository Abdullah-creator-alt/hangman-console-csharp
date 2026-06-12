using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Settings: Basic
    {
        public Settings()
        {
            Console.WriteLine("Wanna change settings");
        }
        public int difficultyLevel(ref bool check)
        {
            check = true;
            Console.WriteLine("Easy");
            Console.WriteLine("Medium");
            Console.WriteLine("Hard");
            Console.WriteLine("Select difficulty");
            string getDifficult = Console.ReadLine();
            int level = difficultyLevel(getDifficult);
            return level;
        }
        public bool revealCount()
        {
            bool reve;
            Console.WriteLine("How many words to reveal \'2 or 3\'");
            try
            {
                int r = Convert.ToInt32(Console.ReadLine());
                if (r < 2 || r > 3)
                {
                    throw new Exception();
                }
                else
                {
                    if (r == 3)
                    {
                        reve = true;
                    }
                    else
                    {
                        reve = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot do this!");
                Console.WriteLine("Going with default");
                reve = false;
            }
            return reve;
        }
    }
}