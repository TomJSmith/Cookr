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
    /// Interaction logic for SearchBarHeader.xaml
    /// </summary>
    public partial class SearchBarHeader : UserControl
    {
        private MainWindow main;
        public SearchBarHeader()
        {
            main = (MainWindow)Window.GetWindow(this);
            InitializeComponent();
        }

        private void clicked(object sender, KeyboardFocusChangedEventArgs e)
        {
            searchBox.Text = "";
        }

        private void homeButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (main == null)
                main = (MainWindow)Window.GetWindow(this);
            main.switchToDiscover();
            main.switchMainView();            
        }

        private void favButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (main == null)
                main = (MainWindow)Window.GetWindow(this);
            main.switchToFavs();
            main.switchMainView();
        }

        private void logoClicked(object sender, MouseButtonEventArgs e)
        {
            if (main == null)
                main = (MainWindow)Window.GetWindow(this);
            main.switchToDiscover();
            main.switchMainView();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (main == null)
                main = (MainWindow)Window.GetWindow(this);
            string searchText = searchBox.Text.ToString();
            Console.WriteLine(searchText);
            SearchView searchResults = new SearchView();
            searchResults.setMain(main);
            if (searchText.ToLower() == "pasta")
            {
                searchResults.initPasta();
            }
            else if (searchText.ToLower() == "breakfast")
            {
                main.switchBreakFastView();
                return;
            }
            else if (searchText.ToLower() == "chicken")
            {
                searchResults.initChicken();
            }
            
            main.switchToView(searchResults);
        }
    }
}
