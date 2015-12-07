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
    /// Interaction logic for OrangeAvocadoChicken.xaml
    /// </summary>
    public partial class OrangeAvocadoChicken : UserControl, IRecipe
    {
        public double recipeValue = 4.0;
        private bool isFav = false;
        public OrangeAvocadoChicken()
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
            MainWindow myMain = (MainWindow)Window.GetWindow(this);
            if (isFav)
            {
                isFav = false;
                favButton.Source = new BitmapImage(new Uri(@"/Images/addFavouritedButton.png", UriKind.Relative));
                myMain.removeFav(this);
            }
            else
            {
                isFav = true;
                favButton.Source = new BitmapImage(new Uri(@"/Images/filledFavouritedButton.png", UriKind.Relative));
                myMain.addFav(this);
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
            label4_Copy1.Content = "1/2 teaspoons Salt";
            label4_Copy5.Content = "1/2 tablespoons\npeanut butter";
            label4_Copy2.Content = "1/4 lb chicken thighs";
            label4_Copy3.Content = "1/4 Avocado, chopped";
            label4_Copy8.Content = "1/4 cup sesame salad\ndressing";
            label4_Copy9.Content = "1/2 tablespoons lime juice";
            label4_Copy10.Content = "1/4 can(15 oz.) Mandarin\nOrange ";
            label4_Copy11.Content = "1/4 Cup chopped peanuts";
            textBlock1.Text = "Whisk together salad dressing, peanut butter, lime peel and juice.  Remove 1/2 tablespoons to a separate container and reserve for later.";
        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "1 teaspoons Salt";
            label4_Copy5.Content = "1 tablespoons\npeanut butter";
            label4_Copy2.Content = "1/2 lb chicken thighs";
            label4_Copy3.Content = "1/2 Avocado, chopped";
            label4_Copy8.Content = "1/4 cup sesame salad\ndressing";
            label4_Copy9.Content = "1 tablespoons lime juice";
            label4_Copy10.Content = "1/2 can(15 oz.) Mandarin\nOrange ";
            label4_Copy11.Content = "1/4 Cup chopped peanuts";
            textBlock1.Text = "Whisk together salad dressing, peanut butter, lime peel and juice.  Remove 1 tablespoon to a separate container and reserve for later.";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "1 and 1/2 teaspoons\nSalt";
            label4_Copy5.Content = "1 and 1/2 tablespoons\npeanut butter";
            label4_Copy2.Content = "3/4 lb chicken thighs";
            label4_Copy3.Content = "3/4 Avocado, chopped";
            label4_Copy8.Content = "1/2 cup sesame salad\ndressing";
            label4_Copy9.Content = "1 and 1/2 tablespoons\nlime juice";
            label4_Copy10.Content = "3/4 can(15 oz.) Mandarin\nOrange ";
            label4_Copy11.Content = "1/2 Cup chopped peanuts";
            textBlock1.Text = "Whisk together salad dressing, peanut butter, lime peel and juice.  Remove 1 and 1/2 tablespoons to a separate container and reserve for later.";
        }

        private void serves4(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content="2 teaspoons Salt";
            label4_Copy5.Content="2 tablespoons\npeanut butter";
            label4_Copy2.Content="1 lb chicken thighs";
            label4_Copy3.Content="1 Avocado, chopped";
            label4_Copy8.Content="1/2 cup sesame salad \ndressing";
            label4_Copy9.Content="2 tablespoons lime juice";
            label4_Copy10.Content="1 can(15 oz.) Mandarin\nOrange ";
            label4_Copy11.Content="1/2 Cup chopped peanuts";
            textBlock1.Text = "Whisk together salad dressing, peanut butter, lime peel and juice.  Remove 2 tablespoons to a separate container and reserve for later.";
        }

        private void serves5(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "2 and 1/2 teaspoons\nSalt";
            label4_Copy5.Content = "2 and 1/2 tablespoons\npeanut butter";
            label4_Copy2.Content = "1 and 1/4 lb chicken\nthighs";
            label4_Copy3.Content = "1 and 1/4 Avocado,\nchopped";
            label4_Copy8.Content = "3/4 cup sesame salad\ndressing";
            label4_Copy9.Content = "2 and 1/2 tablespoons\nlime juice";
            label4_Copy10.Content = "1 and 1/4 can(15 oz.)\nMandarin Orange ";
            label4_Copy11.Content = "3/4 Cup chopped peanuts";
            textBlock1.Text = "Whisk together salad dressing, peanut butter, lime peel and juice.  Remove 2 and 1/2 tablespoons to a separate container and reserve for later.";
        }
    }
}
