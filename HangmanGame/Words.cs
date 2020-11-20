using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HangmanGame
{

    public class Words
    {


        public static string getWord ()
        {
            string listOfWords = "photo,motor,civil,magic,level,greet";

            string [] listOfWordsSorted = listOfWords.Split(',');
            var random = new Random().Next(0,5);
            string wordToGuess = listOfWordsSorted[random];

            return wordToGuess;
       }
    }
}

