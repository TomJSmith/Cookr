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
    /// Interaction logic for BeefTacosView.xaml
    /// </summary>
    public partial class BeefTacosView : UserControl, IRecipe
    {
        public double recipeValue = 4.0;
        private bool isFav = false;
        public BeefTacosView()
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
            label4.Content="small Non-Stick pan";
            label4_Copy1.Content = "1/4 Teaspoon salt";
            label4_Copy13.Content = "1/3 Red or green Serrano\nchilli pepper";
            label4_Copy5.Content = "1/3 cup dried cilantro";
            label4_Copy7.Content = "1/3 cup of Parsley";
            label4_Copy2.Content = "1/3 medium head of\nchopped iceberg lettuce";
            label4_Copy3.Content = "2/3 cups of ready made\nsalsa";
            label4_Copy4.Content = "1/3 packet taco seasoning\nmix";
            label4_Copy15.Content = "1/3 cup sliced Avocado";
            label4_Copy8.Content = "1/2 tsp cumin";
            label4_Copy9.Content = "1/2 tsp minced garlic";
            label4_Copy10.Content = "1/3 pound ground beef";
            label4_Copy11.Content = "1/2 tablespoon olive oil";
            label4_Copy12.Content = "2 large tortillas ";
        }

        private void serves2(object sender, RoutedEventArgs e)
        {
            label4.Content = "medium Non-Stick pan";

            label4_Copy1.Content = "1/4 Teaspoon salt";
            label4_Copy13.Content = "2/3 Red or green Serrano\nchilli pepper";
            label4_Copy5.Content = "2/3 cup dried cilantro";
            label4_Copy7.Content = "2/3 cup of Parsley";
            label4_Copy2.Content = "2/3 medium head of\nchopped iceberg lettuce";
            label4_Copy3.Content = "1 and 1/3 cups of ready made\nsalsa";
            label4_Copy4.Content = "2/3 packet taco seasoning\nmix";
            label4_Copy15.Content = "2/3 cup sliced Avocado";
            label4_Copy8.Content = "1 tsp cumin";
            label4_Copy9.Content = "1 tsp minced garlic";
            label4_Copy10.Content = "2/3 pound ground beef";
            label4_Copy11.Content = "1 tablespoon olive oil";
            label4_Copy12.Content = "4 large tortillas ";
        }

        private void serves3(object sender, RoutedEventArgs e)
        {
            label4.Content = "medium Non-Stick pan";

            label4_Copy1.Content = "1/2 Teaspoon salt";
            label4_Copy13.Content="1 Red or green Serrano\nchilli pepper";
            label4_Copy5.Content="1 cup dried cilantro";
            label4_Copy7.Content="1 cup of Parsley";
            label4_Copy2.Content="1 medium head of\nchopped iceberg lettuce";
            label4_Copy3.Content="2 cups of ready made\nsalsa";
            label4_Copy4.Content="1 packet taco seasoning\nmix";
            label4_Copy15.Content="1 cup sliced Avocado";
            label4_Copy8.Content="1 tsp cumin";
            label4_Copy9.Content="1 tsp minced garlic";
            label4_Copy10.Content="1 pound ground beef";
            label4_Copy11.Content="1 tablespoon olive oil";
            label4_Copy12.Content="6 large tortillas ";
        }

        private void serves4(object sender, RoutedEventArgs e)
        {
            label4.Content = "large Non-Stick pan";

            label4_Copy1.Content = "1 Teaspoon salt";
            label4_Copy13.Content = "1 and 1/3 Red or green\nSerrano chilli pepper";
            label4_Copy5.Content = "1 and 1/3 cup dried cilantro";
            label4_Copy7.Content = "1 and 1/3 cup of Parsley";
            label4_Copy2.Content = "1 and 1/3 medium head\nof chopped iceberg lettuce";
            label4_Copy3.Content = "2 and 2/3 cups of\nready made salsa";
            label4_Copy4.Content = "1 and 1/3 packet\ntaco seasoning mix";
            label4_Copy15.Content = "1 and 1/3 cup sliced\nAvocado";
            label4_Copy8.Content = "1 and 1/2 tsp cumin";
            label4_Copy9.Content = "1 and 1/2 tsp minced\ngarlic";
            label4_Copy10.Content = "1 and 1/3 pound ground\nbeef";
            label4_Copy11.Content = "1 and 1/2 tablespoon\nolive oil";
            label4_Copy12.Content = "8 large tortillas ";

        }

        private void serves5(object sender, RoutedEventArgs e)
        {
            label4.Content = "large Non-Stick pan";

            label4_Copy1.Content = "1 Teaspoon salt";
            label4_Copy13.Content = "1 and 2/3 Red or green\nSerrano chilli pepper";
            label4_Copy5.Content = "1 and 2/3 cup dried cilantro";
            label4_Copy7.Content = "1 and 2/3 cup of Parsley";
            label4_Copy2.Content = "1 and 2/3 medium head\nof chopped iceberg lettuce";
            label4_Copy3.Content = "3 and 1/3 cups of\nready made salsa";
            label4_Copy4.Content = "1 and 2/3 packet\ntaco seasoning mix";
            label4_Copy15.Content = "1 and 2/3 cup sliced\nAvocado";
            label4_Copy8.Content = "2 tsp cumin";
            label4_Copy9.Content = "2 tsp minced garlic";
            label4_Copy10.Content = "1 and 2/3 pound ground\nbeef";
            label4_Copy11.Content = "2 tablespoon\nolive oil";
            label4_Copy12.Content = "10 large tortillas ";
        }


    }
}
