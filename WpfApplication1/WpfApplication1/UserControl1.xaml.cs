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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// discover tab
    public partial class UserControl1 : UserControl
    {
        private MainWindow myMain;
        private UserControl randRecipe;
        public UserControl1(MainWindow mainWindow)
        {
            myMain = mainWindow;
            InitializeComponent();
            randomRecipe(myMain.getRandomRecipe());
        }

        private void TopRatedClick(object sender, RoutedEventArgs e)
        {
            myMain.switchTopRatedView();
        }

        private void catagoriesClick(object sender, RoutedEventArgs e)
        {
            myMain.switchToCatagories();
        }

        private void favsClick(object sender, RoutedEventArgs e)
        {
           myMain.switchToFavs();
        }

        public void randomRecipe(UserControl aRecipe)
        {
            randRecipe = aRecipe;
            IRecipe temp = (IRecipe)aRecipe;
            RandRecipeImage.Source = (ImageSource)temp.getImage();
            randRecipeName.Text = temp.getName();
        }

        private void RandRecipeClick(object sender, MouseButtonEventArgs e)
        {
            myMain.switchToView(randRecipe);
        }
    }
}
