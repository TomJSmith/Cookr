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
    /// Interaction logic for BreakfastCategory.xaml
    /// </summary>
    public partial class BreakfastCategory : UserControl
    {
        private MainWindow myMain;
        public BreakfastCategory(MainWindow aMain)
        {
            InitializeComponent();
            myMain = aMain;
            defaultView();

        }

        void defaultView()
        {

            Sp1.Children.Clear();

            ListItem item1 =  new ListItem(myMain.pancake.getName(),myMain.pancake.getTime(),myMain.pancake);

            Sp1.Children.Add(item1);


        }
    
    
    }// end of BreakfastCategory


} // end of namespace
