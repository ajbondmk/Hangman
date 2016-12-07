using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class MyGame
    {
        public string CurrentWord;                                          //String containing the current word
        public string Display = "Click 'new game'\r\nto begin";             //Set the dsiplay to "Click 'new game' to begin"
        public string Message;                                              //String called Message (what the dialogue box contains)
        public int LifeCount = 6;                                           //Integer containing the number of lives, set to 6
        public bool ActiveGame = false;                                     //Game set to not active
        
        public void NewGame()                                               //When NewGame is called:
        {
            ActiveGame = true;                                                  //Game set to active
            Random Random = new Random();                                       //Create a new random variable
            int WordIndex = Random.Next(WordsClass.Words.Length);               //Find a random integer in the range of the number of words in the list of words
            CurrentWord = WordsClass.Words[WordIndex];                          //Set CurrentWord to the word at that index
            LifeCount = 6;                                                      //Set LifeCount to 6
            Display = "";                                                       //Clear the display
            Message = "";                                                       //Clear the message
            foreach (char C in CurrentWord) Display += "_ ";                    //Display an underscore and a space for each letter in the current word
            Display = Display.Substring(0, Display.Length - 1);                 //Remove the extra space from the end
        }

        public void ProcessButton(char CurrentLetter)                       //When ProcessButton is called:
        {
            int CharPosition;                                                   //Create an integer called CharPosition
            bool Changed = false;                                               //Set Changed to false
            char[] CharDisplay = Display.ToCharArray();                         //Take the Display and put it into an array of characters
            for (int i = 0; i < CurrentWord.Length; i++)                        //For each letter in the current word:
            {
                if (CurrentWord[i] == CurrentLetter)                                //If the current letter is the letter the user chose:
                {
                    CharPosition = 2 * i;                                               //Multiply the letter index by two
                    CharDisplay[CharPosition] = CurrentLetter;                          //Replace the underscore with the correct letter
                    Changed = true;                                                     //Set Changed to equal true
                }
            }
            if (Changed == false) LifeCount--;                                  //If the letter was not in the word (the guess was incorrect), reduce the LifeCount by one
            if (LifeCount == 0)                                                 //If there are no lives left:
            {
                Message = "Game over! The word was '" + CurrentWord + "'." + Environment.NewLine + "Click 'New Game' to have another go.";      //Display a 'game over' message
                ActiveGame = false;                                                 //Game set to not active
            }
            Display = new string(CharDisplay);                                  //Update the display
            if (!Display.Contains("_"))                                         //If there are no underscores (the word has been guessed correctly):
            {
                Message = "Congratulations, you got it!";                           //Display a 'congratulations' message
                ActiveGame = false;                                                 //Game set to not active
            }
        }
    }
}