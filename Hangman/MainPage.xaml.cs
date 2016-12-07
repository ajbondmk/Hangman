using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Hangman
{
    public partial class MainPage : PhoneApplicationPage
    {
        MyGame MyGame;                                                              //Global variable MyGame of type MyGame

        public MainPage()                                                           //When the page is launched:
        {
            InitializeComponent();
            MyGame = new MyGame();                                                      //Create a MyGame object
            WordBlock.Text = MyGame.Display;                                            //Display a message ('Click a new game button to begin')
            InitialiseHangman();                                                        //Call InitialiseHangman
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)          //When the user clicks the New Game button:
        {
            InitialiseHangman();                                                        //Call InitialiseHangman
            MyGame.NewGame();                                                           //Call NewGame in the MyGame class to set up a new game
            MessageBlock.Text = MyGame.Message;                                         //Display what MyGame says should be displayed (in the message box)
            WordBlock.Text = MyGame.Display;                                            //Display what MyGame says should be displayed (the word in underscores)
            LivesLabel.Text = "Lives:";                                                 //Show 'Lives:'
            LivesBlock.Text = "6";                                                      //Underneath, show the number of lives as 6
        }

        private void LetterButton_Click(object sender, RoutedEventArgs e)           //When the user clicks a letter button
        {
            if (MyGame.ActiveGame)                                                      //If a game is running:
            {
                Button LetterButton = (Button)sender;                                       //Find which button has been pressed
                char CurrentLetter = LetterButton.Content.ToString()[0];                    //Find the letter which was on the button
                LetterButton.Visibility = Visibility.Collapsed;                             //Make the button which was clicked invisible
                MyGame.ProcessButton(CurrentLetter);                                        //Call ProcessButton in MyGame
                UpdateDisplay();                                                            //Update the display (call UpdateDisplay)
                WordBlock.Text = MyGame.Display;                                            //Display what MyGame says should be displayed (the word in underscores)
                MessageBlock.Text = MyGame.Message;                                         //Display what MyGame says should be displayed (in the message box)
            }
        }

        private void UpdateDisplay()                                                //When the display is being updated:
        {
            LivesBlock.Text = MyGame.LifeCount.ToString();                              //Display the current number of lives left
            switch (MyGame.LifeCount)                                                   //Depending on the number of lives left, do the following:
            {
                case 5: Hangman1.Visibility = Visibility.Visible;                           //If there are 5 lives:     Make some of the frame visible
                    Hangman2.Visibility = Visibility.Visible;
                    Hangman3.Visibility = Visibility.Visible; break;
                case 4: Hangman4.Visibility = Visibility.Visible;                           //If there are 4 lives:     Make the rest of the frame visible
                    Hangman5.Visibility = Visibility.Visible;
                    Hangman6.Visibility = Visibility.Visible; break;
                case 3: Hangman7.Visibility = Visibility.Visible; break;                    //If there are 3 lives:     Make the head visible
                case 2: Hangman8.Visibility = Visibility.Visible; break;                    //If there are 2 lives:     Make the body visible
                case 1: Hangman9.Visibility = Visibility.Visible;                           //If there is 1 life:       Make the legs visible
                    Hangman10.Visibility = Visibility.Visible; break;
                case 0: Hangman11.Visibility = Visibility.Visible;                          //If there are 0 lives:     Make the arms visible
                    Hangman12.Visibility = Visibility.Visible;
                    LivesLabel.Text = "Score:"; break;                                                                  //Change 'Lives:' to 'Score:'
            }
        }

        private void InitialiseHangman()                                                                                                                //When initialising Hangman (starting a new game):
        {
            foreach (UIElement ctrl in ContentPanel.Children)                                                                                               //For every object on the page:
            {
                if (ctrl.GetType() == typeof(Button)) { Button ThisButton = ((Button)ctrl); ThisButton.Visibility = Visibility.Visible; }                       //Make all buttons visible
                if (ctrl.GetType() == typeof(Rectangle)) { Rectangle ThisRectangle = ((Rectangle)ctrl); ThisRectangle.Visibility = Visibility.Collapsed; }      //Make all rectangles invisible
                if (ctrl.GetType() == typeof(Ellipse)) { Ellipse ThisEllipse = ((Ellipse)ctrl); ThisEllipse.Visibility = Visibility.Collapsed; }                //Make all ellipses invisible
            }
        }

        private void AddWordButton_Click(object sender, RoutedEventArgs e)                          //When the user clicks the Add New Word button:
        {
            NavigationService.Navigate(new Uri("/AddWordsPage.xaml", UriKind.Relative));                //Navigate to the Add New Word page
        }
    }
}