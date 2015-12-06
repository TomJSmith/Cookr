using System;
using System.Collections;
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
    /// Interaction logic for FavoritesTab.xaml
    /// </summary>
    /// favorites tab
     
    public partial class FavoritesTab : UserControl
    {
        private List<IRecipe> myFaves;
        private NoFavouritesMessage message;
        private MainWindow myMain;
        public FavoritesTab(MainWindow mainWindow)
        {
            message = new NoFavouritesMessage();
            myFaves = new List<IRecipe>();
            myMain = mainWindow;
            InitializeComponent();
            updateView();
        }

        private void updateView()
        {
            if (myFaves.Count == 0)
            {
                favStack.Children.Clear();
                favStack.Children.Add(message);
            }
            else
            {
                favStack.Children.Clear();
                for (int i = 0; i < myFaves.Count; i++)
                {
                    favStack.Children.Add(new ListItem(myFaves[i]));
                }
            }
        }

        public void addFavorite(IRecipe aRecipe)
        {
            myFaves.Add(aRecipe);
            updateView();
        }

        public void removeFavourite(IRecipe aRecipe)
        {
            myFaves.Remove(aRecipe);
            updateView();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myMain.switchToDiscover();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            myMain.switchToCatagories();
        }
    }
}