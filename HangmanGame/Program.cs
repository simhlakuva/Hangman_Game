using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string fiveLetterWord;
            fiveLetterWord = Words.getWord();
            int lengthOfWord = fiveLetterWord.Length;
            char[] lettersGuessed = fiveLetterWord.ToCharArray();

            StringBuilder displayToPlayer = new StringBuilder(fiveLetterWord.Length);
            for (int i = 0; i < fiveLetterWord.Length; i++)
                displayToPlayer.Append('_');



            int lives = 3;
            bool Has_Won = false;
            int lettersRevealed = 0;

            string input;
            char lGuess;
            Console.WriteLine("Welcome to hangman game!");
            Console.Write("Guess the following word: ");

            while (!Has_Won && lives > 0)
            {


                input = Console.ReadLine();
                lGuess = input[0];



                if (lettersGuessed.Contains(lGuess))
                {


                    for (int i = 0; i < fiveLetterWord.Length; i++)
                    {
                        if (lettersGuessed[i] == lGuess)
                        {
                            displayToPlayer[i] = fiveLetterWord[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == fiveLetterWord.Length)
                        Has_Won = true;
                }
                else
                {


                    Console.WriteLine("There's no '{0}' in it!", lGuess);
                    Console.WriteLine("You have " + lives-- + " lives left.");
                }

                Console.WriteLine(displayToPlayer.ToString());
            }

            if (Has_Won)
                Console.WriteLine("Congrats! You have won!");
            else
                Console.WriteLine("You lost! The word to guess was '{0}'", fiveLetterWord);

            Console.Write("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}