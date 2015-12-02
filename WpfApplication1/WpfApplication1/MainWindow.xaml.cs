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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FavoritesTab favTab;
        private UserControl1 disTab;
        private CatagoriesTab catTab;

        public MainWindow()
        {
            favTab = new FavoritesTab(this);
            disTab = new UserControl1(this);
            catTab = new CatagoriesTab(this);
            InitializeComponent();
            switchToDiscover();
        }

        public void switchToDiscover()
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(disTab);
        }

        public void switchToCatagories()
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(catTab);
        }

        public void switchToFavs()
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(favTab);
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {

            
      TopRatedWindow tp1 =  new TopRatedWindow();
            this.Hide();
            tp1.Show();
        }

        private void FavoritesTab_Loaded(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
