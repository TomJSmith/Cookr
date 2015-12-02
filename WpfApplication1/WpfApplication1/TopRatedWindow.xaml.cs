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
using System.Globalization;
using System.Configuration;




namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TopRatedWindow2.xaml
    /// </summary>
    public partial class TopRatedWindow : Window
    {
        public TopRatedWindow()
        {
            InitializeComponent();
            Spaghetti test = new Spaghetti();

            ListItem item1ListItem = new ListItem();
            item1ListItem.recipeName.Content = "Spaghetti and \n Meatballs";
            item1ListItem.time.Content = " 30 Mins";
           
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem();
            item2ListItem.recipeName.Content = "Good Ol' \n Beef Tacos";
            item2ListItem.time.Content = "25 mins";
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem();
            item3ListItem.recipeName.Content = "Strawberry, Mango,\n and Yogurt \n Smoothie";
            item3ListItem.time.Content = "5 Mins";
            
            Sp1.Children.Add(item3ListItem);


            ListItem item4ListItem = new ListItem();
            item4ListItem.recipeName.Content = "Orange and Avocado Crowned \n Black Thai Grilled \n Chicken Thighs";
            item4ListItem.time.Content = "25 Mins";
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem();
            item5ListItem.recipeName.Content = "Chicken, Broccoli & \n Pineapple Stir-Fry";
            item5ListItem.time.Content = "30 Mins";
            Sp1.Children.Add(item5ListItem);
           



        }
    }
}
