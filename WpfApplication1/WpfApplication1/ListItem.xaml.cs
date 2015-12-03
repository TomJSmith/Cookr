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
    /// Interaction logic for ListItem.xaml
    /// </summary>
    public partial class ListItem : UserControl
    {

        public string RecipeName;
        public Window TargetWindow;
        public int TimeRequired;
        

        public ListItem(string name, string time1, Window Twindow)
        {
            InitializeComponent();
            recipeName.Content = name;
            time.Content = time1;
            TargetWindow = Twindow;

        }

        public ListItem(string name, string time1)
        {
            InitializeComponent();
            recipeName.Content = name;
            time.Content = time1;

        }

        private string RTitle
        {
            get
            {
                return RecipeName;
            }

            set
            {
                RecipeName = value;
                recipeName.Content = this.RecipeName; //updating the recipeName in XML with the RecipeName of  Class
            }


        } // end of RTitle


        private int RTime
        {
            get
            {
                return TimeRequired;
            }

            set
            {
                TimeRequired = value;
                time.Content = RTime;
            }
        }// end of RTime

        private Window RWindow
        {
            get
            {
                return TargetWindow;
            }

            set
            {
                TargetWindow = value;
                
            }

        }

        public ListItem()
        {
            InitializeComponent();
        }

        private void listItemButtonClick(object sender, RoutedEventArgs e)
        {
           
            Window.GetWindow(this).Close();
            TargetWindow.Show();
        }
    }
}
