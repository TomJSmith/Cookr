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
using System.Windows.Shapes;
using System.Globalization;
using System.Configuration;




namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TopRatedWindow2.xaml
    /// </summary>
    /// 
    
   
    public partial class TopRatedWindow : Window
    {
        public TopRatedWindow()
        {
            InitializeComponent();
            defaultView();


        }




        private void defaultView()
        {
            SpaghettiRecipeView spaghetti =  new SpaghettiRecipeView();
            RecipeView recipeView = new RecipeView();



            Sp1.Children.Clear();
            ListItem item1ListItem = new ListItem("Spaghetti & \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", recipeView);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins",recipeView);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange & Avocado Thai Grilled \n Chicken Thighs","25 Mins",recipeView);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry","30 Mins",recipeView);
            Sp1.Children.Add(item5ListItem);

        }

        private void AlphabeticalSelected(object sender, RoutedEventArgs e)
        {
            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            RecipeView recipeView = new RecipeView();
            Sp1.Children.Clear();

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", recipeView);
            Sp1.Children.Add(item5ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", recipeView);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", recipeView);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange & Avocado Thai Grilled \n Chicken Thighs", "25 Mins", recipeView);
            Sp1.Children.Add(item4ListItem);

            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);
 
            
        }

      

        private void TimeSelected(object sender, RoutedEventArgs e)
        {
            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            RecipeView recipeView = new RecipeView();
            Sp1.Children.Clear();

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", recipeView);
            Sp1.Children.Add(item3ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", recipeView);
            Sp1.Children.Add(item2ListItem);

            ListItem item4ListItem = new ListItem("Orange & Avocado Thai Grilled \n Chicken Thighs", "25 Mins", recipeView);
            Sp1.Children.Add(item4ListItem);

            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", recipeView);
            Sp1.Children.Add(item5ListItem);
    
           }

        private void RatingSelected(object sender, RoutedEventArgs e)
        {

            SpaghettiRecipeView spaghetti = new SpaghettiRecipeView();
            RecipeView recipeView = new RecipeView();
            Sp1.Children.Clear();

            ListItem item1ListItem = new ListItem("Spaghetti and \n Meatballs", " 30 Mins", spaghetti);
            Sp1.Children.Add(item1ListItem);

            ListItem item2ListItem = new ListItem("Good Ol' \n Beef Tacos", "25 mins", recipeView);
            Sp1.Children.Add(item2ListItem);

            ListItem item3ListItem = new ListItem("Hawaii Smoothie", "5 Mins", recipeView);
            Sp1.Children.Add(item3ListItem);

            ListItem item4ListItem = new ListItem("Orange & Avocado Thai Grilled \n Chicken Thighs", "25 Mins", recipeView);
            Sp1.Children.Add(item4ListItem);

            ListItem item5ListItem = new ListItem("Chicken, Broccoli & \n Pineapple Stir-Fry", "30 Mins", recipeView);
            Sp1.Children.Add(item5ListItem);
        }

    
    }
}
