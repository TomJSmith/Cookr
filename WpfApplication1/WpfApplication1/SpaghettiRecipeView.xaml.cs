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
    /// Interaction logic for SpaghettiRecipeView.xaml
    /// </summary>
    public partial class SpaghettiRecipeView : UserControl, IRecipe
    {
        public double recipeValue = 5.0;
        private bool isFav = false;
        public SpaghettiRecipeView()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
        }

        public double getRatingValue()
        {
            return recipeValue;
        }

        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
        }

        private void addFavourite(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            if (isFav)
            {
                isFav = false;
                favButton.Source = new BitmapImage(new Uri(@"/Images/addFavouritedButton.png", UriKind.Relative));
                mainWindow.removeFav(this);
            }
            else
            {
                isFav = true;
                favButton.Source = new BitmapImage(new Uri(@"/Images/filledFavouritedButton.png", UriKind.Relative));
                mainWindow.addFav(this);
            }
        }

        public string getName()
        {
            return (string)name.Content;
        }

        public string getTime()
        {
            return (string)time.Content;            
        }

        public object getImage()
        {
            return image.Source;
        }

        public ImageSource getRating()
        {
            return image2.Source;
        }

        private void serves1(object sender, RoutedEventArgs e)
        {
            label4.Content = "Medium Pot";
            label4_Copy1.Content = "1/2 tablespoons Salt";
            label4_Copy5.Content = "1/4 cup dried parsley";
            label4_Copy7.Content = "1/4 cup of cilantro";
            label4_Copy2.Content = "1/4 large egg";
            label4_Copy3.Content = "1/4 cup plain\ndried breadcrumbs";
            label4_Copy4.Content = "1/4 can crushed tomatoes";
            label4_Copy8.Content = "1/4 cup finely grated\nParmesan";
            label4_Copy9.Content = "1/2 garlic cloves";
            label4_Copy10.Content = "1/4 pound ground beef";
            label4_Copy11.Content = "1/4 tablespoon olive oil";
            label4_Copy12.Content = "1/4 package of spaghetti";
            textBlock1_Copy1.Text = "In a bowl, using the whisk, combine Parmesan, parsley, garlic, egg, 1/4 teaspoon salt, and 1/4 teaspoon pepper. Add beef and breadcrumbs; mix gently with hands. Form into 4 balls.";
        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4.Content = "Large Pot";
            label4_Copy1.Content = "1 tablespoons Salt";
            label4_Copy5.Content = "1/4 cup dried parsley";
            label4_Copy7.Content = "1/4 cup of cilantro";
            label4_Copy2.Content = "1/2 large egg";
            label4_Copy3.Content = "1/4 cup plain\ndried breadcrumbs";
            label4_Copy4.Content = "1/2 can crushed tomatoes";
            label4_Copy8.Content = "1/4 cup finely grated\nParmesan";
            label4_Copy9.Content = "1 garlic cloves";
            label4_Copy10.Content = "1/2 pound ground beef";
            label4_Copy11.Content = "1/2 tablespoon olive oil";
            label4_Copy12.Content = "1/2 package of spaghetti";
            textBlock1_Copy1.Text = "In a bowl, using the whisk, combine Parmesan, parsley, garlic, egg, 1/2 teaspoon salt, and 1/2 teaspoon pepper. Add beef and breadcrumbs; mix gently with hands. Form into 8 balls.";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {
            label4.Content = "Large Pot";
            label4_Copy1.Content = "1 and 1/2 tablespoons Salt";
            label4_Copy5.Content = "1/4 cup dried parsley";
            label4_Copy7.Content = "1/4 cup of cilantro";
            label4_Copy2.Content = "3/4 large egg";
            label4_Copy3.Content = "1/2 cup plain\ndried breadcrumbs";
            label4_Copy4.Content = "3/4 can crushed tomatoes";
            label4_Copy8.Content = "1/2 cup finely grated\nParmesan";
            label4_Copy9.Content = "1 and 1/2 garlic cloves";
            label4_Copy10.Content = "3/4 pound ground beef";
            label4_Copy11.Content = "3/4 tablespoon olive oil";
            label4_Copy12.Content = "3/4 package of spaghetti";
            textBlock1_Copy1.Text = "In a bowl, using the whisk, combine Parmesan, parsley, garlic, egg, 3/4 teaspoon salt, and 3/4 teaspoon pepper. Add beef and breadcrumbs; mix gently with hands. Form into 12 balls.";
        }

        private void serves4(object sender, RoutedEventArgs e)
        {
            label4.Content="Large Pot";
            label4_Copy1.Content="2 tablespoons Salt";
            label4_Copy5.Content="1/4 cup dried parsley";
            label4_Copy7.Content="1/4 cup of cilantro";
            label4_Copy2.Content="1 large egg";
            label4_Copy3.Content="1/2 cup plain\ndried breadcrumbs";
            label4_Copy4.Content="1 can crushed tomatoes";
            label4_Copy8.Content="1/2 cup finely grated\nParmesan";
            label4_Copy9.Content="2 garlic cloves";
            label4_Copy10.Content="1 pound ground beef";
            label4_Copy11.Content="1 tablespoon olive oil";
            label4_Copy12.Content="1 package of spaghetti";    
            textBlock1_Copy1.Text = "In a bowl, using the whisk, combine Parmesan, parsley, garlic, egg, 1 teaspoon salt, and 1 teaspoon pepper. Add beef and breadcrumbs; mix gently with hands. Form into 16 balls.";
        }

        private void serves5(object sender, RoutedEventArgs e)
        {
            label4.Content = "Large Pot";
            label4_Copy1.Content = "2 and 1/2 tablespoons Salt";
            label4_Copy5.Content = "1/2 cup dried parsley";
            label4_Copy7.Content = "1/2 cup of cilantro";
            label4_Copy2.Content = "1 and 1/4 large egg";
            label4_Copy3.Content = "3/4 cup plain\ndried breadcrumbs";
            label4_Copy4.Content = "1 and 1/4 can crushed\ntomatoes";
            label4_Copy8.Content = "3/4 cup finely grated\nParmesan";
            label4_Copy9.Content = "2 and 1/2 garlic cloves";
            label4_Copy10.Content = "1 and 1/4 pound\nground beef";
            label4_Copy11.Content = "1 and 1/4 tablespoon\nolive oil";
            label4_Copy12.Content = "1 and 1/4 package\nof spaghetti";
            textBlock1_Copy1.Text = "In a bowl, using the whisk, combine Parmesan, parsley, garlic, egg, 1 and 1/4 teaspoon salt, and 1 and 1/4 teaspoon pepper. Add beef and breadcrumbs; mix gently with hands. Form into 20 balls.";
        }
    }
}
