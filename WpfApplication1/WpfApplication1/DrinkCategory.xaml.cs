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
    /// Interaction logic for DrinkCategory.xaml
    /// </summary>
    public partial class DrinkCategory : UserControl
    {
        private MainWindow myMain;
        public DrinkCategory(MainWindow aMain)
        {
            myMain = aMain;
            InitializeComponent();
        }
    }
}