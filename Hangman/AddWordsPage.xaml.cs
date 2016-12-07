using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Text.RegularExpressions;

namespace Hangman
{
    public partial class AddWordsPage : PhoneApplicationPage
    {
        public AddWordsPage()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)                      //When the Add To Word List button is clicked:
        {
            AddWords();                                                                         //Call AddWords (to add the words that have been entered)
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));            //Navigate to the MainPage
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)                      //When the Neww Word List button is clicked:
        {
            Array.Resize(ref WordsClass.Words, 0);                                              //Resize the array to length 0 (clear it)
            AddWords();                                                                         //Call AddWords (to add the words that have been entered)
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));            //Navigate to the MainPage
        }

        private void AddWords()                                                             //When adding words:
        {
            var Words = Regex.Matches(NewWordsBox.Text, @"\b[a-zA-Z]{2,}\b");                   //Find all the separate words from the entered text
            foreach (Match Word in Words) ProcessWord(Word.ToString());                         //Process each word in ProcessWord
        }

        private void ProcessWord(string Word)                                               //When processing a new word:
        {
            Array.Resize(ref WordsClass.Words, WordsClass.Words.Length + 1);                    //Increase the size of the word array by one
            WordsClass.Words[WordsClass.Words.Length - 1] = Word.ToUpper();                     //Add the new word to the end of the array (in capitals)
        }
    }
}