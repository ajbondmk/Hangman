﻿#pragma checksum "E:\School\Computing\Aliyah Bond 11B\Hangman\Hangman v2 annotated\Hangman\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3B1E2FEF7B5045B3E3A9A623E568471"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Hangman {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock WordBlock;
        
        internal System.Windows.Controls.Button ButtonQ;
        
        internal System.Windows.Controls.Button ButtonW;
        
        internal System.Windows.Controls.Button ButtonE;
        
        internal System.Windows.Controls.Button ButtonR;
        
        internal System.Windows.Controls.Button ButtonT;
        
        internal System.Windows.Controls.Button ButtonY;
        
        internal System.Windows.Controls.Button ButtonU;
        
        internal System.Windows.Controls.Button ButtonI;
        
        internal System.Windows.Controls.Button ButtonO;
        
        internal System.Windows.Controls.Button ButtonP;
        
        internal System.Windows.Controls.Button ButtonA;
        
        internal System.Windows.Controls.Button ButtonS;
        
        internal System.Windows.Controls.Button ButtonD;
        
        internal System.Windows.Controls.Button ButtonF;
        
        internal System.Windows.Controls.Button ButtonG;
        
        internal System.Windows.Controls.Button ButtonH;
        
        internal System.Windows.Controls.Button ButtonJ;
        
        internal System.Windows.Controls.Button ButtonK;
        
        internal System.Windows.Controls.Button ButtonL;
        
        internal System.Windows.Controls.Button ButtonZ;
        
        internal System.Windows.Controls.Button ButtonX;
        
        internal System.Windows.Controls.Button ButtonC;
        
        internal System.Windows.Controls.Button ButtonV;
        
        internal System.Windows.Controls.Button ButtonB;
        
        internal System.Windows.Controls.Button ButtonN;
        
        internal System.Windows.Controls.Button ButtonM;
        
        internal System.Windows.Controls.TextBlock MessageBlock;
        
        internal System.Windows.Controls.Button NewGameButton;
        
        internal System.Windows.Shapes.Rectangle Hangman1;
        
        internal System.Windows.Shapes.Rectangle Hangman2;
        
        internal System.Windows.Shapes.Rectangle Hangman3;
        
        internal System.Windows.Shapes.Rectangle Hangman4;
        
        internal System.Windows.Shapes.Rectangle Hangman5;
        
        internal System.Windows.Shapes.Rectangle Hangman6;
        
        internal System.Windows.Shapes.Ellipse Hangman7;
        
        internal System.Windows.Shapes.Rectangle Hangman8;
        
        internal System.Windows.Shapes.Rectangle Hangman9;
        
        internal System.Windows.Shapes.Rectangle Hangman10;
        
        internal System.Windows.Shapes.Rectangle Hangman11;
        
        internal System.Windows.Shapes.Rectangle Hangman12;
        
        internal System.Windows.Controls.TextBlock LivesBlock;
        
        internal System.Windows.Controls.TextBlock LivesLabel;
        
        internal System.Windows.Controls.Button AddWordButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Hangman;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.WordBlock = ((System.Windows.Controls.TextBlock)(this.FindName("WordBlock")));
            this.ButtonQ = ((System.Windows.Controls.Button)(this.FindName("ButtonQ")));
            this.ButtonW = ((System.Windows.Controls.Button)(this.FindName("ButtonW")));
            this.ButtonE = ((System.Windows.Controls.Button)(this.FindName("ButtonE")));
            this.ButtonR = ((System.Windows.Controls.Button)(this.FindName("ButtonR")));
            this.ButtonT = ((System.Windows.Controls.Button)(this.FindName("ButtonT")));
            this.ButtonY = ((System.Windows.Controls.Button)(this.FindName("ButtonY")));
            this.ButtonU = ((System.Windows.Controls.Button)(this.FindName("ButtonU")));
            this.ButtonI = ((System.Windows.Controls.Button)(this.FindName("ButtonI")));
            this.ButtonO = ((System.Windows.Controls.Button)(this.FindName("ButtonO")));
            this.ButtonP = ((System.Windows.Controls.Button)(this.FindName("ButtonP")));
            this.ButtonA = ((System.Windows.Controls.Button)(this.FindName("ButtonA")));
            this.ButtonS = ((System.Windows.Controls.Button)(this.FindName("ButtonS")));
            this.ButtonD = ((System.Windows.Controls.Button)(this.FindName("ButtonD")));
            this.ButtonF = ((System.Windows.Controls.Button)(this.FindName("ButtonF")));
            this.ButtonG = ((System.Windows.Controls.Button)(this.FindName("ButtonG")));
            this.ButtonH = ((System.Windows.Controls.Button)(this.FindName("ButtonH")));
            this.ButtonJ = ((System.Windows.Controls.Button)(this.FindName("ButtonJ")));
            this.ButtonK = ((System.Windows.Controls.Button)(this.FindName("ButtonK")));
            this.ButtonL = ((System.Windows.Controls.Button)(this.FindName("ButtonL")));
            this.ButtonZ = ((System.Windows.Controls.Button)(this.FindName("ButtonZ")));
            this.ButtonX = ((System.Windows.Controls.Button)(this.FindName("ButtonX")));
            this.ButtonC = ((System.Windows.Controls.Button)(this.FindName("ButtonC")));
            this.ButtonV = ((System.Windows.Controls.Button)(this.FindName("ButtonV")));
            this.ButtonB = ((System.Windows.Controls.Button)(this.FindName("ButtonB")));
            this.ButtonN = ((System.Windows.Controls.Button)(this.FindName("ButtonN")));
            this.ButtonM = ((System.Windows.Controls.Button)(this.FindName("ButtonM")));
            this.MessageBlock = ((System.Windows.Controls.TextBlock)(this.FindName("MessageBlock")));
            this.NewGameButton = ((System.Windows.Controls.Button)(this.FindName("NewGameButton")));
            this.Hangman1 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman1")));
            this.Hangman2 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman2")));
            this.Hangman3 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman3")));
            this.Hangman4 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman4")));
            this.Hangman5 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman5")));
            this.Hangman6 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman6")));
            this.Hangman7 = ((System.Windows.Shapes.Ellipse)(this.FindName("Hangman7")));
            this.Hangman8 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman8")));
            this.Hangman9 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman9")));
            this.Hangman10 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman10")));
            this.Hangman11 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman11")));
            this.Hangman12 = ((System.Windows.Shapes.Rectangle)(this.FindName("Hangman12")));
            this.LivesBlock = ((System.Windows.Controls.TextBlock)(this.FindName("LivesBlock")));
            this.LivesLabel = ((System.Windows.Controls.TextBlock)(this.FindName("LivesLabel")));
            this.AddWordButton = ((System.Windows.Controls.Button)(this.FindName("AddWordButton")));
        }
    }
}

