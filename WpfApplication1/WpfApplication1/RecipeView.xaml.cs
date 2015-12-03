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
    public partial class RecipeView : UserControl
    {
        public RecipeView()
        {
            InitializeComponent();
        }

        private void addFavourite(object sender, MouseButtonEventArgs e)
        {
            favButton.Source = new BitmapImage(new Uri(@"/Images/filledFavouritedButton.png", UriKind.Relative));
        }

        private void goBack(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.switchPrevView();
        }
    }
}
