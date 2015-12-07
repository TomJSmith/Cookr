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
    /// Interaction logic for BreakfastPage.xaml
    /// </summary>
    public partial class BreakfastPage : UserControl, IRecipe
    {
        public double recipeValue = 3.0;
        private bool isFav = false;
        public BreakfastPage()
        {
            InitializeComponent();
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

        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4.Content="10 inch\nnon-stick pan";
            label4_Copy1.Content="1 teaspoon Salt";
            label4_Copy5.Content="2 tablespoons sugar";
            label4_Copy2.Content="1 large egg";
            label4_Copy3.Content="2 tablespoons canola\noil";
            label4_Copy8.Content="1 cup All-purpose flour";
            label4_Copy9.Content="Baking pouder";
            label4_Copy10.Content="1 cup milk";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {

        }

        private void serves4(object sender, RoutedEventArgs e)
        {

        }

        private void serves5(object sender, RoutedEventArgs e)
        {

        }
    }
}
