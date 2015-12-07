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
    /// Interaction logic for HawaiianSmoothie.xaml
    /// </summary>
    public partial class HawaiianSmoothie : UserControl, IRecipe
    {
        private bool isFav = false;
        public HawaiianSmoothie()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
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
            label4_Copy1.Content = "2/3 cup apple Juice";
            label4_Copy15.Content = "1/2 cup low-fat \nplain yogurt";
            label4_Copy13.Content = "1/2 cup fresh or \nfrozen strawberries";
            label4_Copy8.Content = "1 cup fresh or \nfrozen mango chunks";
            label4_Copy7.Content = "2/3 cup orange juice";
        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "1 and 1/4 cups apple Juice";
            label4_Copy15.Content = "1 cup low-fat \nplain yogurt";
            label4_Copy13.Content = "1 cup fresh or \nfrozen strawberries";
            label4_Copy8.Content = "2 cups fresh or \nfrozen mango chunks";
            label4_Copy7.Content = "1 and 1/4 cup orange juice";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "1 and 3/4 cups apple Juice";
            label4_Copy15.Content = "1 and 1/2 cup low-fat\nplain yogurt";
            label4_Copy13.Content = "1 and 1/2 cup fresh\nor frozen strawberries";
            label4_Copy8.Content = "3 cups fresh\nor frozen mango chunks";
            label4_Copy7.Content = "1 and 3/4 cup orange juice";
        }

        private void serves4(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "2 and 1/2 cups apple Juice";
            label4_Copy15.Content = "2 cup low-fat\nplain yogurt";
            label4_Copy13.Content = "2 cup fresh\nor frozen strawberries";
            label4_Copy8.Content = "4 cups fresh\nor frozen mango chunks";
            label4_Copy7.Content = "2 and 1/2 cup orange juice";
        }

        private void serves5(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "3 and 1/4 cups apple Juice";
            label4_Copy15.Content = "2 and 1/2 cup low-fat\nplain yogurt";
            label4_Copy13.Content = "2 and 1/2 cup fresh\nor frozen strawberries";
            label4_Copy8.Content = "5 cups fresh\nor frozen mango chunks";
            label4_Copy7.Content = "3 and 1/4 cup orange juice";
        }

        private void serves6(object sender, RoutedEventArgs e)
        {
            label4_Copy1.Content = "3 and 3/4 cups apple Juice";
            label4_Copy15.Content = "3 cup low-fat\nplain yogurt";
            label4_Copy13.Content = "3 cup fresh\nor frozen strawberries";
            label4_Copy8.Content = "6 cups fresh\nor frozen mango chunks";
            label4_Copy7.Content = "3 and 3/4 cup orange juice";
        }
    }
}
