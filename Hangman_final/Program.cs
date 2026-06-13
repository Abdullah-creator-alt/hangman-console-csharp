using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry;
            Console.WriteLine("\t\tHangman Game");
            Console.WriteLine("\nPress any key to start");
            Console.ReadKey();
            Console.WriteLine();
            IRandomizer game;
            Basic function = new Basic();
            Settings settings = new Settings();

            string ask = get_input();
            ask = ask.ToUpper();

            bool difficulty = false;
            bool reve = false;
            int id = 0;
            if (ask[0] == 'Y')
            {
                Console.WriteLine("Want to change difficulty");
                string cd = get_input();
                cd = cd.ToUpper();

                if ((cd[0] == 'Y'))
                {
                    id = settings.difficultyLevel(ref difficulty);
                }


                Console.WriteLine("Want to change revealed words");
                string cr = get_input();
                cr = cr.ToUpper();

                if ((cr[0] == 'Y'))
                {
                    reve = settings.revealCount();
                }
            }
            do
            {
                if (difficulty == true)
                {
                    game = new RandDiff();
                }
                else
                {
                    game = new RandAll();
                }

                string original = game.getWord(id);
                string revealed = game.reveal(reve, original);
                Console.WriteLine("Your word is");
                Console.WriteLine(revealed);
                Score thescore = new Score(original);
                Console.WriteLine("Guess the missing letters");
                int i = 1;
                do
                {
                    thescore.dispTable(original, revealed, i - 1);
                    char got = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    revealed = game.update(original, revealed, got);
                    Console.WriteLine();
                    Console.WriteLine(revealed);
                    if (!function.checkIt(original, got))
                    {
                        i++;
                    }
                } while (!function.done(original, revealed) && i <= function.getChances(original));

                if (function.done(original, revealed))
                {
                    Console.WriteLine("CONGRATULATIONS! The man escaped the rope");
                }
                else
                {
                    Console.WriteLine("GAME OVER! The man died");
                }

                retry = false;
                Console.WriteLine("\nWanna play again");
                string retry_str = get_input();
                retry_str = retry_str.ToUpper();

                if (retry_str == null)
                {
                    break;
                }
                else if (retry_str[0] == 'Y')
                {
                    retry = true;
                }

                Console.WriteLine();
            } while (retry);
        }

        public static string get_input()
        {
            string str = Console.ReadLine();
            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Cannot leave it empty, try again.");
                bool this_con = false;
                do
                {
                    str = Console.ReadLine();
                    if (str != null)
                        this_con = true;
                } while (!this_con);
            }

            return str;
        }
    }
}
