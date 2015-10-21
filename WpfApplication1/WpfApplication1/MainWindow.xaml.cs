﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchBox_Focused(object sender, KeyboardFocusChangedEventArgs e)
        {
            searchBox.Text = "";
        }

        private void SearchBox_Lost_Focus(object sender, KeyboardFocusChangedEventArgs e)
        {
            searchBox.Text = "(e.g. pickles, Thai, sandwiches)";
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void discoverButton_Click(object sender, RoutedEventArgs e)
        {
            RecipePage window = new RecipePage();
            window.Show();
            this.Close();
        }

        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            LogIn logInPage = new LogIn();
            logInPage.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            LogIn logInPage = new LogIn();
            logInPage.Show();
            this.Hide();
        }
    }
}
