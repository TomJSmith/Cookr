﻿using System;
using System.Collections;
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
    /// Interaction logic for FavoritesTab.xaml
    /// </summary>
    /// favorites tab
     
    public partial class FavoritesTab : UserControl
    {
        private ArrayList myFaves;
        private MainWindow myMain;
        public FavoritesTab(MainWindow mainWindow)
        {
            myFaves = new ArrayList();
            myMain = mainWindow;
            InitializeComponent();
        }

        public void addFavorite(UserControl aRecipe)
        {
            myFaves.Add(aRecipe);
        }

        public void removeFavourite(UserControl aRecipe)
        {
            myFaves.Remove(aRecipe);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myMain.switchToDiscover();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            myMain.switchToCatagories();
        }
    }
}