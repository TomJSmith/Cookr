using System;
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
            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            RecipeView recipeView = new RecipeView();

            Sp1.Children.Clear();
            ListItem item1ListItem = new ListItem(myMain.spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' Beef Tacos", "25 mins", recipeView);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", recipeView);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange & Avocado Chicken Thighs", "25 Mins", recipeView);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & Pineapple Stir-Fry", "30 Mins", recipeView);
            Sp1.Children.Add(item5ListItem);

            ListItem item6ListItem = new ListItem();
            Sp1.Children.Add(item6ListItem);

            ListItem item7ListItem = new ListItem();
            Sp1.Children.Add(item7ListItem);
        }
    
    
    }// end of BreakfastCategory


} // end of namespace
