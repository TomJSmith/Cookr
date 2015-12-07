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
    /// Interaction logic for sundaeDessert.xaml
    /// </summary>
    public partial class sundaeDessert : UserControl, IRecipe
    {
        public double recipeValue = 4.5;
        private bool isFav = false;
        public sundaeDessert()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
        }


        public double getRatingValue()
        {
            return recipeValue;
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

        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
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
            label4_Copy1.Content = "1 tablespoon butter";
            label4_Copy5.Content = "1/4 tablespoon honey";
            label4_Copy2.Content = "1/4 cup canned pineapple";
            label4_Copy3.Content = "1/16 of a 10 ounce pound\ncake, thawed and crumbled ";
            label4_Copy4.Content = "1 maraschino cherries\nwith stems";
            label4_Copy8.Content = "1 tablespoon packed\nbrown sugar";
            label4_Copy9.Content = "a pinch of ground\ncinnamon";
            label4_Copy10.Content = "1/4 pint vanilla ice cream";
        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "2 tablespoon butter";
            label4_Copy5.Content = "1/2 tablespoon honey";
            label4_Copy2.Content = "1/2 cup canned pineapple";
            label4_Copy3.Content = "1/8 of a 10 ounce pound\ncake, thawed and crumbled ";
            label4_Copy4.Content = "2 maraschino cherries\nwith stems";
            label4_Copy8.Content = "2 tablespoon packed\nbrown sugar";
            label4_Copy9.Content = "a pinch of ground\ncinnamon";
            label4_Copy10.Content = "1/2 pint vanilla ice cream";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "3 tablespoon butter";
            label4_Copy5.Content = "3/4 tablespoon honey";
            label4_Copy2.Content = "3/4 cup canned pineapple";
            label4_Copy3.Content = "1/4 of a 10 ounce pound\ncake, thawed and crumbled ";
            label4_Copy4.Content = "3 maraschino cherries\nwith stems";
            label4_Copy8.Content = "3 tablespoon packed\nbrown sugar";
            label4_Copy9.Content = "a pinch of ground\ncinnamon";
            label4_Copy10.Content = "3/4 pint vanilla ice cream";
        }

        private void serves4(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content="4 tablespoons butter";
            label4_Copy5.Content="1 tablespoon honey";
            label4_Copy2.Content="1 cup canned pineapple";
            label4_Copy3.Content="1/4 of a 10 ounce pound\ncake, thawed and crumbled ";
            label4_Copy4.Content="4 maraschino cherries\nwith stems";
            label4_Copy8.Content="1/4 cup packed\nbrown sugar";
            label4_Copy9.Content="1/8 teaspoon ground\ncinnamon";
            label4_Copy10.Content="1 pint vanilla ice cream";
        }

        private void serves5(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "5 tablespoons butter";
            label4_Copy5.Content = "1 and 1/4 tablespoon\nhoney";
            label4_Copy2.Content = "1 and 1/4 cup canned\npineapple";
            label4_Copy3.Content = "1/4 of a 10 ounce pound\ncake, thawed and crumbled ";
            label4_Copy4.Content = "5 maraschino cherries\nwith stems";
            label4_Copy8.Content = "5 tablespoon packed\nbrown sugar";
            label4_Copy9.Content = "1/8 teaspoon of ground\ncinnamon";
            label4_Copy10.Content = "1 and 1/4 pint vanilla\nice cream";
        }
    }
}
