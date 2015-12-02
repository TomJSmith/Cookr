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
        public SearchBarHeader()
        {
            InitializeComponent();
        }

        private void clicked(object sender, KeyboardFocusChangedEventArgs e)
        {
            searchBox.Text = "";
        }

        private void homeButtonClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
            main.Show();
        }

        private void favButtonClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            Window parentWindow = Window.GetWindow(this);
            main.switchToFavs();
            parentWindow.Close();
            main.Show();
        }

        private void logoClicked(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
            main.Show();
        }
    }
}
