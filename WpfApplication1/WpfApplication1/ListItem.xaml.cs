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

        public UserControl targetUserControl;
        

        public ListItem()
        {
            InitializeComponent();
        }
        
        public ListItem(string aName, string aTime, UserControl aUserControl)
        {
            InitializeComponent();
            recipeName.Content = aName;
          
            time.Content = aTime;
            targetUserControl = aUserControl;
        }

      
        public ListItem(string name, string time1)
        {
            InitializeComponent();
            recipeName.Content = name;
            time.Content = time1;
        }


        private void listItemButtonClick(object sender, RoutedEventArgs e)
        {

            MainWindow main = (MainWindow)Window.GetWindow(this);
            if (targetUserControl == null)
                targetUserControl = new RecipeView();
            main.switchToView(this.targetUserControl);

        }

        

    }
}
