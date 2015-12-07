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
    /// Interaction logic for StirFry.xaml
    /// </summary>
    public partial class StirFry : UserControl, IRecipe
    {
        public double ratingValue = 3.0;
        private bool isFav = false;
        public StirFry()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
        }


        public double getRatingValue()
        {
            return ratingValue;
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
            label4_Copy15.Content = "1/8 pound chicken breast\ncut into strips";
            label4_Copy1.Content = "1/2 cloves of garlic\nchopped";
            label4_Copy5.Content = "1/8 cup of soy sauce";
            label4_Copy2.Content = "1/8 teaspoon cinnamon";
            label4_Copy3.Content = "1/4 red bell pepper cut into\nchunks";
            label4_Copy4.Content = "1/2 cups of canned\npineapple chunks ";
            label4_Copy16.Content = "1/4 medium onion, sliced";
            label4_Copy8.Content = "1/4 cup chicken broth";
            label4_Copy9.Content = "1/4 tablespoon cornstarch";
            label4_Copy10.Content = "1/2 cups brocolli";
            label4_Copy11.Content = "1/2 teaspoon olive\noil";
            label4_Copy14.Content = "1/2 teaspoon canola oil";
        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4_Copy15.Content = "1/4 pound chicken breast\ncut into strips";
            label4_Copy1.Content = "1 cloves of garlic\nchopped";
            label4_Copy5.Content = "1/4 cup of soy sauce";
            label4_Copy2.Content = "1/4 teaspoon cinnamon";
            label4_Copy3.Content = "1/2 red bell pepper cut\ninto chunks";
            label4_Copy4.Content = "1 cups of canned\npineapple chunks ";
            label4_Copy16.Content = "1/2 medium onion, sliced";
            label4_Copy8.Content = "1/2 cup chicken broth";
            label4_Copy9.Content = "1/2 tablespoon cornstarch";
            label4_Copy10.Content = "1 cups brocolli";
            label4_Copy11.Content = "1 teaspoon olive\noil";
            label4_Copy14.Content = "1 teaspoon canola oil";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {
            label4_Copy15.Content = "3/8 pound chicken breast\ncut into strips";
            label4_Copy1.Content = "1 and 1/2 cloves of\ngarlic chopped";
            label4_Copy5.Content = "3/8 cup of soy sauce";
            label4_Copy2.Content = "3/8 teaspoon cinnamon";
            label4_Copy3.Content = "3/4 red bell pepper cut\ninto chunks";
            label4_Copy4.Content = "1 and 1/2 cups of canned\npineapple chunks ";
            label4_Copy16.Content = "3/4 medium onion, sliced";
            label4_Copy8.Content = "3/4 cup chicken broth";
            label4_Copy9.Content = "3/4 tablespoon cornstarch";
            label4_Copy10.Content = "1 and 1/2 cups brocolli";
            label4_Copy11.Content = "1 and 1/2 teaspoon\nolive oil";
            label4_Copy14.Content = "1 and 1/2 teaspoon\ncanola oil";
        }

        private void serves4(object sender, RoutedEventArgs e)
        {
            label4_Copy15.Content="1/2 pound chicken breast\ncut into strips";
            label4_Copy1.Content="2 cloves of garlic\nchopped";
            label4_Copy5.Content="1/4 cup of soy sauce";
            label4_Copy2.Content="1/4 teaspoon cinnamon";
            label4_Copy3.Content="1 red bell pepper cut\ninto chunks";
            label4_Copy4.Content="2 cups of canned\npineapple chunks ";
            label4_Copy16.Content="1 medium onion, sliced";
            label4_Copy8.Content="1 cup chicken broth";
            label4_Copy9.Content="1 tablespoon cornstarch";
            label4_Copy10.Content="2 cups brocolli";
            label4_Copy11.Content="2 teaspoon olive oil";
            label4_Copy14.Content="2 teaspoon canola oil";
        }

        private void serves5(object sender, RoutedEventArgs e)
        {
            label4_Copy15.Content = "5/8 pound chicken breast\ncut into strips";
            label4_Copy1.Content = "2 and 1/2 cloves of\ngarlic chopped";
            label4_Copy5.Content = "5/8 cup of soy sauce";
            label4_Copy2.Content = "5/8 teaspoon cinnamon";
            label4_Copy3.Content = "1 and 1/4 red bell pepper\ncut into chunks";
            label4_Copy4.Content = "2 and 1/2 cups of canned\npineapple chunks ";
            label4_Copy16.Content = "1 and 1/4 medium\nonion, sliced";
            label4_Copy8.Content = "1 and 1/4 cup\nchicken broth";
            label4_Copy9.Content = "1 and 1/4 tablespoon\ncornstarch";
            label4_Copy10.Content = "2 and 1/2 cups brocolli";
            label4_Copy11.Content = "2 and 1/2 teaspoon\nolive oil";
            label4_Copy14.Content = "2 and 1/2 teaspoon\ncanola oil";
        }
    }
}
