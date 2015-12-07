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
    /// Interaction logic for RecipeView.xaml
    /// </summary>
    public partial class RecipeView : UserControl, IRecipe
    {
        private double recipeValue = 0;

        private bool isFav = false;
        public RecipeView()
        {
            InitializeComponent();
            recipeValue = 5.0;
        }

        public double getRatingValue()
        {
            return recipeValue;
        }

        public RecipeView(string aName, string aTime, double aRating)
        {
            InitializeComponent();
            recipeValue = aRating;
            name.Content = aName;
            time.Content = aTime;
            if (aRating == 0.5)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/halfstar.png", UriKind.Relative));
            }
            else if (aRating == 1.0)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/1star.png", UriKind.Relative));
            }
            else if (aRating == 1.5)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/15star.png", UriKind.Relative));
            }
            else if (aRating == 2.0)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/2star.png", UriKind.Relative));
            }
            else if (aRating == 2.5)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/25star.png", UriKind.Relative));
            }
            else if (aRating == 3.0)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/3star.png", UriKind.Relative));
            }
            else if (aRating == 3.5)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/35star.png", UriKind.Relative));
            }
            else if (aRating == 4.0)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/4star.png", UriKind.Relative));
            }
            else if (aRating == 4.5)
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/45star.png", UriKind.Relative));
            }
            else
            {
                image2.Source = new BitmapImage(new Uri(@"/Images/5star.png", UriKind.Relative));
            }
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
    }
}
