//Author: Emily Flowers
//Course: CSCI2503
//Assignment: Assign06
//Last Modified: 04 / 11 / 2026

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Assign06
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // event handler for Clear button
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            userName.Text = "Name";
            monthSelection.SelectedItem = null;
            seasonSelection.SelectedItem = null;
            resultsText.Text = " ";
        }

        // event handler for Enter button
        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            // check that all fields are completed
            if (userName.Text.Length > 0 && monthSelection.SelectedItem != null && seasonSelection.SelectedItem != null)
            {                          
            
            // get index of both selections and add them together then mod 7
            int selectionTotal = (monthSelection.SelectedIndex + seasonSelection.SelectedIndex) % 7;

            // switch statement to determine cat chosen
            String cat = "default";
            switch (selectionTotal)
            {
                case 0:
                    cat = "Garfield";
                    break;
                case 1:
                    cat = "Pusheen";
                    break;
                case 2:
                    cat = "Hello Kitty";
                    break;
                case 3:
                    cat = "Jiji";
                    break;
                case 4:
                    cat = "Cheshire Cat";
                    break;
                case 5:
                    cat = "Chester Cheeto";
                    break;
                case 6:
                    cat = "Puss In Boots";
                    break;
           
            }
                resultsText.Text = userName.Text + ", your spirit animal is " + cat;
            }
            else
            {
                resultsText.Text = "Please complete all fields and then select Enter.";
            }


        }

        private void birthMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
