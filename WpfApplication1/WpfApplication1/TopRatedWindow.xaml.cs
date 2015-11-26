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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TopRatedWindow.xaml
    /// </summary>
    public partial class TopRatedWindow : Window
    {
        public TopRatedWindow()
        {
            InitializeComponent();
            // this is for the header and the searchbar usercontrol
            SearchBarHeader sh1 =  new SearchBarHeader();
            headerSearchPanel.Children.Add(sh1);

            // this is for the list itme
            ListItem li1 = new ListItem();
            li1.RecipeName = "Meatballs";
            this.recipeListPanel.Children.Add(li1);


        }// end of TopRatedWindow
    }
}
