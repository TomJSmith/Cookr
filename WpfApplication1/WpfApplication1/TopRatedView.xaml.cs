﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TopRatedView.xaml
    /// </summary>
    public partial class TopRatedView : UserControl
    {
        private MainWindow myMain;

        public TopRatedView(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
            defaultView();
        }
        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
        }


        private void defaultView()
        {
            Sp1.Children.Clear();

            // ListItem[] itemOfLists = new ListItem[5];
            myMain.itemOfLists[0] = new ListItem(myMain.spaghetti);
            myMain.itemOfLists[1] = new ListItem(myMain.beefTacos);
            myMain.itemOfLists[2] = new ListItem(myMain.aSundae);
            myMain.itemOfLists[3] = new ListItem(myMain.orangeAvoChicken);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

            Sp1.Children.Clear();
            myMain.sortRating();
            

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }



        }





        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {
            myMain.itemOfLists[0] = new ListItem(myMain.spaghetti);
            myMain.itemOfLists[1] = new ListItem(myMain.beefTacos);
            myMain.itemOfLists[2] = new ListItem(myMain.aSundae);
            myMain.itemOfLists[3] = new ListItem(myMain.orangeAvoChicken);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

           

            Sp1.Children.Clear();

            myMain.sortAlphabetically();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }



        }



        private void TimeSelected(object sender, RoutedEventArgs e)
        {

            myMain.itemOfLists[0] = new ListItem(myMain.spaghetti);
            myMain.itemOfLists[1] = new ListItem(myMain.beefTacos);
            myMain.itemOfLists[2] = new ListItem(myMain.aSundae);
            myMain.itemOfLists[3] = new ListItem(myMain.orangeAvoChicken);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);
            
            Sp1.Children.Clear(); 

            myMain.sortTime();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }



        }


        private void RatingSelected(object sender, RoutedEventArgs e)
        {

            myMain.itemOfLists[0] = new ListItem(myMain.spaghetti);
            myMain.itemOfLists[1] = new ListItem(myMain.beefTacos);
            myMain.itemOfLists[2] = new ListItem(myMain.aSundae);
            myMain.itemOfLists[3] = new ListItem(myMain.orangeAvoChicken);
            myMain.itemOfLists[4] = new ListItem(myMain.hawiianSmoothie);

          
            
            Sp1.Children.Clear();

            myMain.sortRating();

            for (int i = 0; i < myMain.itemOfLists.Length; i++)
            {

                Sp1.Children.Add(myMain.itemOfLists[i]);
            }


        }


    }
}// end of TopRated